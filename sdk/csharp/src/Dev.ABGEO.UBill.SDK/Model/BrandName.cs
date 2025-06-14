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
    /// BrandName
    /// </summary>
    public partial class BrandName : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandName" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="authorized">authorized</param>
        /// <param name="createdAt">createdAt</param>
        [JsonConstructor]
        public BrandName(string id, string name, string authorized, string createdAt)
        {
            Id = id;
            Name = name;
            Authorized = authorized;
            CreatedAt = createdAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>ubill-info</example> */
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Authorized
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("authorized")]
        public string Authorized { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /* <example>2025-05-28 10:07:18</example> */
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrandName {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Authorized: ").Append(Authorized).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
    /// A Json converter for type <see cref="BrandName" />
    /// </summary>
    public class BrandNameJsonConverter : JsonConverter<BrandName>
    {
        /// <summary>
        /// Deserializes json to <see cref="BrandName" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BrandName Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<string?> name = default;
            Option<string?> authorized = default;
            Option<string?> createdAt = default;

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
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "authorized":
                            authorized = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "createdAt":
                            createdAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class BrandName.", nameof(id));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class BrandName.", nameof(name));

            if (!authorized.IsSet)
                throw new ArgumentException("Property is required for class BrandName.", nameof(authorized));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class BrandName.", nameof(createdAt));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class BrandName.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class BrandName.");

            if (authorized.IsSet && authorized.Value == null)
                throw new ArgumentNullException(nameof(authorized), "Property is not nullable for class BrandName.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class BrandName.");

            return new BrandName(id.Value!, name.Value!, authorized.Value!, createdAt.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="BrandName" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="brandName"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BrandName brandName, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, brandName, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BrandName" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="brandName"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, BrandName brandName, JsonSerializerOptions jsonSerializerOptions)
        {
            if (brandName.Id == null)
                throw new ArgumentNullException(nameof(brandName.Id), "Property is required for class BrandName.");

            if (brandName.Name == null)
                throw new ArgumentNullException(nameof(brandName.Name), "Property is required for class BrandName.");

            if (brandName.Authorized == null)
                throw new ArgumentNullException(nameof(brandName.Authorized), "Property is required for class BrandName.");

            if (brandName.CreatedAt == null)
                throw new ArgumentNullException(nameof(brandName.CreatedAt), "Property is required for class BrandName.");

            writer.WriteString("id", brandName.Id);

            writer.WriteString("name", brandName.Name);

            writer.WriteString("authorized", brandName.Authorized);

            writer.WriteString("createdAt", brandName.CreatedAt);
        }
    }
}
