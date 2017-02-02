/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// ItemRelationships
    /// </summary>
    [DataContract]
    public partial class ItemRelationships :  IEquatable<ItemRelationships>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ItemRelationships() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRelationships" /> class.
        /// </summary>
        /// <param name="Parent">Parent (required).</param>
        /// <param name="Tip">Tip (required).</param>
        /// <param name="Versions">Versions (required).</param>
        /// <param name="Refs">Refs (required).</param>
        public ItemRelationships(JsonApiRelationshipsLinksInternalResource Parent = null, JsonApiRelationshipsLinksInternalResource Tip = null, JsonApiRelationshipsLinksInternal Versions = null, JsonApiRelationshipsLinksRefs Refs = null)
        {
            // to ensure "Parent" is required (not null)
            if (Parent == null)
            {
                throw new InvalidDataException("Parent is a required property for ItemRelationships and cannot be null");
            }
            else
            {
                this.Parent = Parent;
            }
            // to ensure "Tip" is required (not null)
            if (Tip == null)
            {
                throw new InvalidDataException("Tip is a required property for ItemRelationships and cannot be null");
            }
            else
            {
                this.Tip = Tip;
            }
            // to ensure "Versions" is required (not null)
            if (Versions == null)
            {
                throw new InvalidDataException("Versions is a required property for ItemRelationships and cannot be null");
            }
            else
            {
                this.Versions = Versions;
            }
            // to ensure "Refs" is required (not null)
            if (Refs == null)
            {
                throw new InvalidDataException("Refs is a required property for ItemRelationships and cannot be null");
            }
            else
            {
                this.Refs = Refs;
            }
        }
        
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksInternalResource Parent { get; set; }
        /// <summary>
        /// Gets or Sets Tip
        /// </summary>
        [DataMember(Name="tip", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksInternalResource Tip { get; set; }
        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksInternal Versions { get; set; }
        /// <summary>
        /// Gets or Sets Refs
        /// </summary>
        [DataMember(Name="refs", EmitDefaultValue=false)]
        public JsonApiRelationshipsLinksRefs Refs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemRelationships {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tip: ").Append(Tip).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  Refs: ").Append(Refs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ItemRelationships);
        }

        /// <summary>
        /// Returns true if ItemRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of ItemRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemRelationships other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Tip == other.Tip ||
                    this.Tip != null &&
                    this.Tip.Equals(other.Tip)
                ) && 
                (
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.Equals(other.Versions)
                ) && 
                (
                    this.Refs == other.Refs ||
                    this.Refs != null &&
                    this.Refs.Equals(other.Refs)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Tip != null)
                    hash = hash * 59 + this.Tip.GetHashCode();
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                if (this.Refs != null)
                    hash = hash * 59 + this.Refs.GetHashCode();
                return hash;
            }
        }
    }

}
