// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagedDeviceMobileAppConfigurationRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedDeviceMobileAppConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedDeviceMobileAppConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceStatuses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationDeviceStatusesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationDeviceStatusesCollectionRequestBuilder DeviceStatuses { get; }

        /// <summary>
        /// Gets the request builder for DeviceStatusSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationDeviceSummaryRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationDeviceSummaryRequestBuilder DeviceStatusSummary { get; }

        /// <summary>
        /// Gets the request builder for UserStatuses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationUserStatusesCollectionRequestBuilder UserStatuses { get; }

        /// <summary>
        /// Gets the request builder for UserStatusSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationUserSummaryRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationUserSummaryRequestBuilder UserStatusSummary { get; }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceMobileAppConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationAssignRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationAssignRequestBuilder Assign(
            IEnumerable<ManagedDeviceMobileAppConfigurationAssignment> assignments = null);
    
    }
}
