// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

﻿namespace Microsoft.Azure.Batch
{
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using Models = Microsoft.Azure.Batch.Protocol.Models;

    internal class AsyncListSupportedImagesEnumerator : PagedEnumeratorBase<ImageInformation>
    {
        private readonly PoolOperations _parentPoolOps;
        private readonly BehaviorManager _behaviorMgr;
        private readonly DetailLevel _detailLevel;

        #region // constructors

        internal AsyncListSupportedImagesEnumerator(
            PoolOperations parentPoolOps,
            BehaviorManager behaviorMgr,
            DetailLevel detailLevel)
        {
            _parentPoolOps = parentPoolOps;
            _behaviorMgr = behaviorMgr;
            _detailLevel = detailLevel;
        }

        #endregion // constructors

        public override ImageInformation Current  // for IPagedEnumerator<T> and IEnumerator<T>
        {
            get
            {
                // start with the current object off of base
                object curObj = base._currentBatch[base._currentIndex];

                // it must be a protocol object from previous call
                Models.ImageInformation protocolObj = curObj as Models.ImageInformation;

                Debug.Assert(null != protocolObj);

                // wrap protocol object
                ImageInformation wrapped = new ImageInformation(protocolObj);

                return wrapped;
            }
        }

        /// <summary>
        /// fetch another batch of objects from the server
        /// </summary>
        protected async override System.Threading.Tasks.Task GetNextBatchFromServerAsync(SkipTokenHandler skipHandler, CancellationToken cancellationToken)
        {
            do
            {
                // start the protocol layer call
                var asyncTask = _parentPoolOps.ParentBatchClient.ProtocolLayer.ListSupportedImages(
                    skipHandler.SkipToken,
                    _behaviorMgr,
                    _detailLevel,
                    cancellationToken);

                // wait for protocol call to complete
                var response = await asyncTask.ConfigureAwait(continueOnCapturedContext: false);

                // remember any skiptoken returned.  This also sets the bool
                skipHandler.SkipToken = response.Body.NextPageLink;

                // remember the protocol objects returned
                base._currentBatch = null;

                if (null != response.Body.GetEnumerator())
                {
                    base._currentBatch = response.Body.ToArray();
                }
            }
            // it is possible for there to be no results so we keep trying
            while (skipHandler.ThereIsMoreData && ((null == _currentBatch) || (_currentBatch.Length <= 0)));
        }
    }
}