// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EducationTeacher.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class EducationTeacher
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationTeacher"/> class.
        /// </summary>
        public EducationTeacher()
        {
            this.ODataType = "microsoft.graph.educationTeacher";
        }

        /// <summary>
        /// Gets or sets externalId.
        /// ID of the teacher in the source system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets teacherNumber.
        /// Teacher number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teacherNumber", Required = Newtonsoft.Json.Required.Default)]
        public string TeacherNumber { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
