// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The metadata related to an access key for a given database account.
    /// </summary>
    public partial class AccountKeyMetadata
    {
        /// <summary>
        /// Initializes a new instance of the AccountKeyMetadata class.
        /// </summary>
        public AccountKeyMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountKeyMetadata class.
        /// </summary>
        /// <param name="generationTime">Generation time in UTC of the key in
        /// ISO-8601 format. A value of null means that the last key
        /// regeneration was triggered before 2022-06-18.</param>
        public AccountKeyMetadata(System.DateTime? generationTime = default(System.DateTime?))
        {
            GenerationTime = generationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets generation time in UTC of the key in ISO-8601 format. A value
        /// of null means that the last key regeneration was triggered before
        /// 2022-06-18.
        /// </summary>
        [JsonProperty(PropertyName = "generationTime")]
        public System.DateTime? GenerationTime { get; private set; }

    }
}
