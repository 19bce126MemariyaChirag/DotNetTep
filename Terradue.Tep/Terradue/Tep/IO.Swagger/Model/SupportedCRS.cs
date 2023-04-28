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
    /// SupportedCRS
    /// </summary>
    [DataContract]
    public partial class SupportedCRS : IEquatable<SupportedCRS>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedCRS" /> class.
        /// </summary>
        /// <param name="crs">crs.</param>
        /// <param name="_default">_default (default to false).</param>
        public SupportedCRS(string crs, bool? _default = false)
        {
            this.Crs = crs;
            // use default value if no "_default" provided
            if (_default == null)
            {
                this.Default = false;
            }
            else
            {
                this.Default = _default;
            }
        }

        /// <summary>
        /// Gets or Sets Crs
        /// </summary>
        [DataMember(Name = "crs", EmitDefaultValue = false)]
        public string Crs { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportedCRS {\n");
            sb.Append("  Crs: ").Append(Crs).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as SupportedCRS);
        }

        /// <summary>
        /// Returns true if SupportedCRS instances are equal
        /// </summary>
        /// <param name="input">Instance of SupportedCRS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedCRS input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Crs == input.Crs ||
                    (this.Crs != null &&
                    this.Crs.Equals(input.Crs))
                ) &&
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
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
                if (this.Crs != null)
                    hashCode = hashCode * 59 + this.Crs.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                return hashCode;
            }
        }
    }
}
