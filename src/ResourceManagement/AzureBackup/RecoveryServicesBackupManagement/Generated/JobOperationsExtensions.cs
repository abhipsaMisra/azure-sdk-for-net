// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class JobOperationsExtensions
    {
        /// <summary>
        /// Cancel the job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static JobResponse CancelJob(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).CancelJobAsync(resourceGroupName, resourceName, jobName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Cancel the job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<JobResponse> CancelJobAsync(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.CancelJobAsync(resourceGroupName, resourceName, jobName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Export job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static JobResponse ExportJob(this IJobOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).ExportJobAsync(resourceGroupName, resourceName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Export job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<JobResponse> ExportJobAsync(this IJobOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ExportJobAsync(resourceGroupName, resourceName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the details of specific job Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static JobResponse Get(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).GetAsync(resourceGroupName, resourceName, jobName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the details of specific job Objects.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<JobResponse> GetAsync(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetAsync(resourceGroupName, resourceName, jobName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the operation result of specific job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static JobResponse GetOperationResult(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).GetOperationResultAsync(resourceGroupName, resourceName, jobName, operationId, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the operation result of specific job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='jobName'>
        /// Required.
        /// </param>
        /// <param name='operationId'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a ProtectedItemResponse.
        /// </returns>
        public static Task<JobResponse> GetOperationResultAsync(this IJobOperations operations, string resourceGroupName, string resourceName, string jobName, string operationId, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetOperationResultAsync(resourceGroupName, resourceName, jobName, operationId, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list  of jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a JobListResponse.
        /// </returns>
        public static JobListResponse List(this IJobOperations operations, string resourceGroupName, string resourceName, CommonJobQueryFilters queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobOperations)s).ListAsync(resourceGroupName, resourceName, queryFilter, paginationParams, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list  of jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IJobOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. ResourceGroupName for recoveryServices Vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. ResourceName for recoveryServices Vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a JobListResponse.
        /// </returns>
        public static Task<JobListResponse> ListAsync(this IJobOperations operations, string resourceGroupName, string resourceName, CommonJobQueryFilters queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, resourceName, queryFilter, paginationParams, customRequestHeaders, CancellationToken.None);
        }
    }
}
