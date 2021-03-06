// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class to specify configurations of PlayReady in Streaming Policy
    /// </summary>
    public partial class StreamingPolicyPlayReadyConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyPlayReadyConfiguration class.
        /// </summary>
        public StreamingPolicyPlayReadyConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyPlayReadyConfiguration class.
        /// </summary>
        /// <param name="customLicenseAcquisitionUrlTemplate">The template for
        /// a customer service to deliver keys to end users.  Not needed when
        /// using Azure Media Services for issuing keys.</param>
        /// <param name="playReadyCustomAttributes">Custom attributes for
        /// PlayReady</param>
        public StreamingPolicyPlayReadyConfiguration(string customLicenseAcquisitionUrlTemplate = default(string), string playReadyCustomAttributes = default(string))
        {
            CustomLicenseAcquisitionUrlTemplate = customLicenseAcquisitionUrlTemplate;
            PlayReadyCustomAttributes = playReadyCustomAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template for a customer service to deliver keys to
        /// end users.  Not needed when using Azure Media Services for issuing
        /// keys.
        /// </summary>
        [JsonProperty(PropertyName = "customLicenseAcquisitionUrlTemplate")]
        public string CustomLicenseAcquisitionUrlTemplate { get; set; }

        /// <summary>
        /// Gets or sets custom attributes for PlayReady
        /// </summary>
        [JsonProperty(PropertyName = "playReadyCustomAttributes")]
        public string PlayReadyCustomAttributes { get; set; }

    }
}
