// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Reference to a Key Vault secret.
    /// </summary>
    public partial class SecretValueReference
    {
        /// <summary>
        /// Initializes a new instance of the SecretValueReference class.
        /// </summary>
        public SecretValueReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecretValueReference class.
        /// </summary>
        /// <param name="keyVault">Specifies the reference to a given Azure Key
        /// Vault.</param>
        /// <param name="secretName">Name of the secret.</param>
        /// <param name="secretVersion">The version of the secret to use. If
        /// left blank, the latest version of the secret is used.</param>
        public SecretValueReference(KeyVaultReference keyVault, string secretName, string secretVersion = default(string))
        {
            KeyVault = keyVault;
            SecretName = secretName;
            SecretVersion = secretVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the reference to a given Azure Key Vault.
        /// </summary>
        [JsonProperty(PropertyName = "keyVault")]
        public KeyVaultReference KeyVault { get; set; }

        /// <summary>
        /// Gets or sets name of the secret.
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }

        /// <summary>
        /// Gets or sets the version of the secret to use. If left blank, the
        /// latest version of the secret is used.
        /// </summary>
        [JsonProperty(PropertyName = "secretVersion")]
        public string SecretVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyVault == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyVault");
            }
            if (SecretName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretName");
            }
            if (KeyVault != null)
            {
                KeyVault.Validate();
            }
        }
    }
}
