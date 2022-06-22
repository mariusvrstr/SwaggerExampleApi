/* 
 * SwaggerApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SearchLibraryRequest
    /// </summary>
    [DataContract]
    public partial class SearchLibraryRequest :  IEquatable<SearchLibraryRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines BookFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BookFormatEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum Hardcover for value: Hardcover
            /// </summary>
            [EnumMember(Value = "Hardcover")]
            Hardcover = 2,
            
            /// <summary>
            /// Enum Ebook for value: Ebook
            /// </summary>
            [EnumMember(Value = "Ebook")]
            Ebook = 3,
            
            /// <summary>
            /// Enum Audiobook for value: Audiobook
            /// </summary>
            [EnumMember(Value = "Audiobook")]
            Audiobook = 4
        }

        /// <summary>
        /// Gets or Sets BookFormat
        /// </summary>
        [DataMember(Name="BookFormat", EmitDefaultValue=false)]
        public BookFormatEnum? BookFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchLibraryRequest" /> class.
        /// </summary>
        /// <param name="titleName">titleName.</param>
        /// <param name="bookFormat">bookFormat.</param>
        public SearchLibraryRequest(string titleName = default(string), BookFormatEnum? bookFormat = default(BookFormatEnum?))
        {
            this.TitleName = titleName;
            this.BookFormat = bookFormat;
        }
        
        /// <summary>
        /// Gets or Sets TitleName
        /// </summary>
        [DataMember(Name="TitleName", EmitDefaultValue=false)]
        public string TitleName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchLibraryRequest {\n");
            sb.Append("  TitleName: ").Append(TitleName).Append("\n");
            sb.Append("  BookFormat: ").Append(BookFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchLibraryRequest);
        }

        /// <summary>
        /// Returns true if SearchLibraryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchLibraryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchLibraryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TitleName == input.TitleName ||
                    (this.TitleName != null &&
                    this.TitleName.Equals(input.TitleName))
                ) && 
                (
                    this.BookFormat == input.BookFormat ||
                    (this.BookFormat != null &&
                    this.BookFormat.Equals(input.BookFormat))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TitleName != null)
                    hashCode = hashCode * 59 + this.TitleName.GetHashCode();
                if (this.BookFormat != null)
                    hashCode = hashCode * 59 + this.BookFormat.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}