// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Connector mapping property format.
    /// </summary>
    public partial class ConnectorMappingFormat
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMappingFormat class.
        /// </summary>
        public ConnectorMappingFormat() { }

        /// <summary>
        /// Initializes a new instance of the ConnectorMappingFormat class.
        /// </summary>
        /// <param name="columnDelimiter">The character that signifies a break
        /// between columns.</param>
        /// <param name="acceptLanguage">The oData language.</param>
        /// <param name="quoteCharacter">Quote character, used to indicate
        /// enquoted fields.</param>
        /// <param name="quoteEscapeCharacter">Escape character for quotes, can
        /// be the same as the quoteCharacter.</param>
        /// <param name="arraySeparator">Character separating array
        /// elements.</param>
        public ConnectorMappingFormat(string columnDelimiter = default(string), string acceptLanguage = default(string), string quoteCharacter = default(string), string quoteEscapeCharacter = default(string), string arraySeparator = default(string))
        {
            ColumnDelimiter = columnDelimiter;
            AcceptLanguage = acceptLanguage;
            QuoteCharacter = quoteCharacter;
            QuoteEscapeCharacter = quoteEscapeCharacter;
            ArraySeparator = arraySeparator;
        }
        /// <summary>
        /// Static constructor for ConnectorMappingFormat class.
        /// </summary>
        static ConnectorMappingFormat()
        {
            FormatType = "TextFormat";
        }

        /// <summary>
        /// Gets or sets the character that signifies a break between columns.
        /// </summary>
        [JsonProperty(PropertyName = "columnDelimiter")]
        public string ColumnDelimiter { get; set; }

        /// <summary>
        /// Gets or sets the oData language.
        /// </summary>
        [JsonProperty(PropertyName = "acceptLanguage")]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets quote character, used to indicate enquoted fields.
        /// </summary>
        [JsonProperty(PropertyName = "quoteCharacter")]
        public string QuoteCharacter { get; set; }

        /// <summary>
        /// Gets or sets escape character for quotes, can be the same as the
        /// quoteCharacter.
        /// </summary>
        [JsonProperty(PropertyName = "quoteEscapeCharacter")]
        public string QuoteEscapeCharacter { get; set; }

        /// <summary>
        /// Gets or sets character separating array elements.
        /// </summary>
        [JsonProperty(PropertyName = "arraySeparator")]
        public string ArraySeparator { get; set; }

        /// <summary>
        /// The type mapping format.
        /// </summary>
        [JsonProperty(PropertyName = "formatType")]
        public static string FormatType { get; private set; }

    }
}

