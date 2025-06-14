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
    /// SMSPayload
    /// </summary>
    public partial class SMSPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSPayload" /> class.
        /// </summary>
        /// <param name="brandID">brandID</param>
        /// <param name="numbers">numbers</param>
        /// <param name="text">text</param>
        /// <param name="stopList">Enable/disable checking numbers in the stop list</param>
        [JsonConstructor]
        public SMSPayload(long brandID, List<long> numbers, string text, bool stopList)
        {
            BrandID = brandID;
            Numbers = numbers;
            Text = text;
            StopList = stopList;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets BrandID
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("brandID")]
        public long BrandID { get; set; }

        /// <summary>
        /// Gets or Sets Numbers
        /// </summary>
        [JsonPropertyName("numbers")]
        public List<long> Numbers { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        /* <example>Hello</example> */
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Enable/disable checking numbers in the stop list
        /// </summary>
        /// <value>Enable/disable checking numbers in the stop list</value>
        [JsonPropertyName("stopList")]
        public bool StopList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SMSPayload {\n");
            sb.Append("  BrandID: ").Append(BrandID).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  StopList: ").Append(StopList).Append("\n");
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
    /// A Json converter for type <see cref="SMSPayload" />
    /// </summary>
    public class SMSPayloadJsonConverter : JsonConverter<SMSPayload>
    {
        /// <summary>
        /// Deserializes json to <see cref="SMSPayload" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SMSPayload Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> brandID = default;
            Option<List<long>?> numbers = default;
            Option<string?> text = default;
            Option<bool?> stopList = default;

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
                        case "brandID":
                            brandID = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "numbers":
                            numbers = new Option<List<long>?>(JsonSerializer.Deserialize<List<long>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "text":
                            text = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "stopList":
                            stopList = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!brandID.IsSet)
                throw new ArgumentException("Property is required for class SMSPayload.", nameof(brandID));

            if (!numbers.IsSet)
                throw new ArgumentException("Property is required for class SMSPayload.", nameof(numbers));

            if (!text.IsSet)
                throw new ArgumentException("Property is required for class SMSPayload.", nameof(text));

            if (!stopList.IsSet)
                throw new ArgumentException("Property is required for class SMSPayload.", nameof(stopList));

            if (brandID.IsSet && brandID.Value == null)
                throw new ArgumentNullException(nameof(brandID), "Property is not nullable for class SMSPayload.");

            if (numbers.IsSet && numbers.Value == null)
                throw new ArgumentNullException(nameof(numbers), "Property is not nullable for class SMSPayload.");

            if (text.IsSet && text.Value == null)
                throw new ArgumentNullException(nameof(text), "Property is not nullable for class SMSPayload.");

            if (stopList.IsSet && stopList.Value == null)
                throw new ArgumentNullException(nameof(stopList), "Property is not nullable for class SMSPayload.");

            return new SMSPayload(brandID.Value!.Value!, numbers.Value!, text.Value!, stopList.Value!.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="SMSPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sMSPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SMSPayload sMSPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, sMSPayload, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SMSPayload" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sMSPayload"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, SMSPayload sMSPayload, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sMSPayload.Numbers == null)
                throw new ArgumentNullException(nameof(sMSPayload.Numbers), "Property is required for class SMSPayload.");

            if (sMSPayload.Text == null)
                throw new ArgumentNullException(nameof(sMSPayload.Text), "Property is required for class SMSPayload.");

            writer.WriteNumber("brandID", sMSPayload.BrandID);

            writer.WritePropertyName("numbers");
            JsonSerializer.Serialize(writer, sMSPayload.Numbers, jsonSerializerOptions);
            writer.WriteString("text", sMSPayload.Text);

            writer.WriteBoolean("stopList", sMSPayload.StopList);
        }
    }
}
