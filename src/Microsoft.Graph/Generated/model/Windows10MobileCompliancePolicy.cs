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
    /// The type Windows10Mobile Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10MobileCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The Windows10MobileCompliancePolicy constructor
		///</summary>
        public Windows10MobileCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.windows10MobileCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets bit locker enabled.
        /// Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bitLockerEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? BitLockerEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets code integrity enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "codeIntegrityEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? CodeIntegrityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets early launch anti malware driver enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "earlyLaunchAntiMalwareDriverEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? EarlyLaunchAntiMalwareDriverEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Windows Phone version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Windows Phone version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Whether or not to block syncing the calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before password expiration. Valid values 1 to 255
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum password length. Valid values 4 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// The number of previous passwords to prevent re-use of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock Windows Phone device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password require to unlock from idle.
        /// Require a password to unlock an idle device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequireToUnlockFromIdle", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequireToUnlockFromIdle { get; set; }
    
        /// <summary>
        /// Gets or sets secure boot enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureBootEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecureBootEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on windows devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

