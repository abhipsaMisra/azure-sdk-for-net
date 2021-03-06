// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{

    /// <summary>
    /// Defines values for Verbosity.
    /// </summary>
    public static class Verbosity
    {
        /// <summary>
        /// All the traces emitted by trace policies will be sent to the logger
        /// attached to this diagnostic instance.
        /// </summary>
        public const string Verbose = "verbose";
        /// <summary>
        /// Traces with 'severity' set to 'information' and 'error' will be
        /// sent to the logger attached to this diagnostic instance.
        /// </summary>
        public const string Information = "information";
        /// <summary>
        /// Only traces with 'severity' set to 'error' will be sent to the
        /// logger attached to this diagnostic instance.
        /// </summary>
        public const string Error = "error";
    }
}
