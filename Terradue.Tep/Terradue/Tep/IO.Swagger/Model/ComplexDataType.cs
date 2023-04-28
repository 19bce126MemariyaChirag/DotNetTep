/* 
 * The OGC API - Processes
 *
 * WARNING - THIS IS WORK IN PROGRESS
 *
 * OpenAPI spec version: 1.0-draft.5
 * Contact: b.pross@52north.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ComplexDataType
    /// </summary>
    [DataContract]
        public partial class ComplexDataType :  IEquatable<ComplexDataType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexDataType" /> class.
        /// </summary>
        /// <param name="formats">formats (required).</param>
        public ComplexDataType(List<FormatDescription> formats)
        {
            // to ensure "formats" is required (not null)
            if (formats == null)
            {
                throw new InvalidDataException("formats is a required property for ComplexDataType and cannot be null");
            }
            else
            {
                this.Formats = formats;
            }
        }
        
        /// <summary>
        /// Gets or Sets Formats
        /// </summary>
        [DataMember(Name="formats", EmitDefaultValue=false)]
        public List<FormatDescription> Formats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComplexDataType {\n");
            sb.Append("  Formats: ").Append(Formats).Append("\n");
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
            return this.Equals(input as ComplexDataType);
        }

        /// <summary>
        /// Returns true if ComplexDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexDataType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Formats == input.Formats ||
                    this.Formats != null &&
                    input.Formats != null &&
                    this.Formats.SequenceEqual(input.Formats)
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
                if (this.Formats != null)
                    hashCode = hashCode * 59 + this.Formats.GetHashCode();
                return hashCode;
            }
        }
    }
}
