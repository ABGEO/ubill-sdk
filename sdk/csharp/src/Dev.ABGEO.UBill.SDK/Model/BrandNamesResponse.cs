// <auto-generated>
/*
 * UBill API
 *
 * UBill API - provides programmatic access to our resources. You will be able to integrate our service into your system and communicate with clients easily.
 *
 * The version of the OpenAPI document: 2.1.7
 * Contact: info@ubill.ge
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Dev.ABGEO.UBill.SDK.Client;

namespace Dev.ABGEO.UBill.SDK.Model
{
    /// <summary>
    /// BrandNamesResponse
    /// </summary>
    public partial class BrandNamesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandNamesResponse" /> class.
        /// </summary>
        /// <param name="statusID">Response status code</param>
        /// <param name="brands">List of available brand names</param>
        /// <param name="message">Human-readable response message</param>
        [JsonConstructor]
        public BrandNamesResponse(long statusID, List<BrandName> brands, Option<string?> message = default)
        {
            StatusID = statusID;
            Brands = brands;
            MessageOption = message;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Response status code
        /// </summary>
        /// <value>Response status code</value>
        /* <example>0</example> */
        [JsonPropertyName("statusID")]
        public long StatusID { get; set; }

        /// <summary>
        /// List of available brand names
        /// </summary>
        /// <value>List of available brand names</value>
        [JsonPropertyName("brands")]
        public List<BrandName> Brands { get; set; }

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MessageOption { get; private set; }

        /// <summary>
        /// Human-readable response message
        /// </summary>
        /// <value>Human-readable response message</value>
        /* <example>Success</example> */
        [JsonPropertyName("message")]
        public string? Message { get { return this.MessageOption; } set { this.MessageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrandNamesResponse {\n");
            sb.Append("  StatusID: ").Append(StatusID).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="BrandNamesResponse" />
    /// </summary>
    public class BrandNamesResponseJsonConverter : JsonConverter<BrandNamesResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="BrandNamesResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BrandNamesResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> statusID = default;
            Option<List<BrandName>?> brands = default;
            Option<string?> message = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "statusID":
                            statusID = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "brands":
                            brands = new Option<List<BrandName>?>(JsonSerializer.Deserialize<List<BrandName>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!statusID.IsSet)
                throw new ArgumentException("Property is required for class BrandNamesResponse.", nameof(statusID));

            if (!brands.IsSet)
                throw new ArgumentException("Property is required for class BrandNamesResponse.", nameof(brands));

            if (statusID.IsSet && statusID.Value == null)
                throw new ArgumentNullException(nameof(statusID), "Property is not nullable for class BrandNamesResponse.");

            if (brands.IsSet && brands.Value == null)
                throw new ArgumentNullException(nameof(brands), "Property is not nullable for class BrandNamesResponse.");

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class BrandNamesResponse.");

            return new BrandNamesResponse(statusID.Value!.Value!, brands.Value!, message);
        }

        /// <summary>
        /// Serializes a <see cref="BrandNamesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="brandNamesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BrandNamesResponse brandNamesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, brandNamesResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BrandNamesResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="brandNamesResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BrandNamesResponse brandNamesResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (brandNamesResponse.Brands == null)
                throw new ArgumentNullException(nameof(brandNamesResponse.Brands), "Property is required for class BrandNamesResponse.");

            if (brandNamesResponse.MessageOption.IsSet && brandNamesResponse.Message == null)
                throw new ArgumentNullException(nameof(brandNamesResponse.Message), "Property is required for class BrandNamesResponse.");

            writer.WriteNumber("statusID", brandNamesResponse.StatusID);

            writer.WritePropertyName("brands");
            JsonSerializer.Serialize(writer, brandNamesResponse.Brands, jsonSerializerOptions);
            if (brandNamesResponse.MessageOption.IsSet)
                writer.WriteString("message", brandNamesResponse.Message);
        }
    }
}
