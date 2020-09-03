// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management Troubleshooting Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementTroubleshootingEvent : Entity
    {
    
		///<summary>
		/// The DeviceManagementTroubleshootingEvent constructor
		///</summary>
        public DeviceManagementTroubleshootingEvent()
        {
            this.ODataType = "microsoft.graph.deviceManagementTroubleshootingEvent";
        }
	
        /// <summary>
        /// Gets or sets correlation id.
        /// Id used for tracing the failure in the service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// Time when the event occurred .
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EventDateTime { get; set; }
    
    }
}

