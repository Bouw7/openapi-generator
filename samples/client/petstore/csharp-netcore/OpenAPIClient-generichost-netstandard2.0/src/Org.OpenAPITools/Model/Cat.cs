// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Cat
    /// </summary>
    public partial class Cat : Animal, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat" /> class.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="catAllOf"></param>
        /// <param name="className">className</param>
        /// <param name="color">color (default to &quot;red&quot;)</param>
        [JsonConstructor]
        internal Cat(Dictionary<string, int> dictionary, CatAllOf catAllOf, string className, string color = @"red") : base(className, color)
        {
            Dictionary = dictionary;
            CatAllOf = catAllOf;
        }

        /// <summary>
        /// Gets or Sets Dictionary
        /// </summary>
        public Dictionary<string, int> Dictionary { get; set; }

        /// <summary>
        /// Gets or Sets CatAllOf
        /// </summary>
        public CatAllOf CatAllOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Cat {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type Cat
    /// </summary>
    public class CatJsonConverter : JsonConverter<Cat>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Cat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Utf8JsonReader dictionaryReader = utf8JsonReader;
            bool dictionaryDeserialized = Client.ClientUtils.TryDeserialize<Dictionary<string, int>>(ref utf8JsonReader, jsonSerializerOptions, out Dictionary<string, int> dictionary);

            Utf8JsonReader catAllOfReader = utf8JsonReader;
            bool catAllOfDeserialized = Client.ClientUtils.TryDeserialize<CatAllOf>(ref utf8JsonReader, jsonSerializerOptions, out CatAllOf catAllOf);

            string className = default;
            string color = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "className":
                            className = utf8JsonReader.GetString();
                            break;
                        case "color":
                            color = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new Cat(dictionary, catAllOf, className, color);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Cat cat, JsonSerializerOptions jsonSerializerOptions)
        {
            System.Text.Json.JsonSerializer.Serialize(writer, cat.Dictionary, jsonSerializerOptions);

            System.Text.Json.JsonSerializer.Serialize(writer, cat.CatAllOf, jsonSerializerOptions);

        }
    }
}
