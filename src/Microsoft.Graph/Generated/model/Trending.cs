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
    /// The type Trending.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Trending : Entity
    {
    
		///<summary>
		/// The Trending constructor
		///</summary>
        public Trending()
        {
            this.ODataType = "microsoft.graph.trending";
        }
	
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets resource reference.
        /// Reference properties of the trending document, such as the url and type of the document.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceReference", Required = Newtonsoft.Json.Required.Default)]
        public ResourceReference ResourceReference { get; set; }
    
        /// <summary>
        /// Gets or sets resource visualization.
        /// Properties that you can use to visualize the document in your experience.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceVisualization", Required = Newtonsoft.Json.Required.Default)]
        public ResourceVisualization ResourceVisualization { get; set; }
    
        /// <summary>
        /// Gets or sets weight.
        /// Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weight", Required = Newtonsoft.Json.Required.Default)]
        public double? Weight { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Used for navigating to the trending document.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resource", Required = Newtonsoft.Json.Required.Default)]
        public Entity Resource { get; set; }
    
    }
}

