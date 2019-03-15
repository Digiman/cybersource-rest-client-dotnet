/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// TssV2TransactionsGet200ResponsePaymentInformationPaymentType
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationPaymentType :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationPaymentType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationPaymentType" /> class.
        /// </summary>
        /// <param name="Name">The description for this field is not available..</param>
        /// <param name="Type">The description for this field is not available..</param>
        /// <param name="SubType">The description for this field is not available..</param>
        /// <param name="Method">The description for this field is not available..</param>
        /// <param name="FundingSource">The description for this field is not available..</param>
        /// <param name="FundingSourceAffiliation">The description for this field is not available..</param>
        /// <param name="Credential">The description for this field is not available..</param>
        public TssV2TransactionsGet200ResponsePaymentInformationPaymentType(string Name = default(string), string Type = default(string), string SubType = default(string), string Method = default(string), string FundingSource = default(string), string FundingSourceAffiliation = default(string), string Credential = default(string))
        {
            this.Name = Name;
            this.Type = Type;
            this.SubType = SubType;
            this.Method = Method;
            this.FundingSource = FundingSource;
            this.FundingSourceAffiliation = FundingSourceAffiliation;
            this.Credential = Credential;
        }
        
        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public string SubType { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public string FundingSource { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="fundingSourceAffiliation", EmitDefaultValue=false)]
        public string FundingSourceAffiliation { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="credential", EmitDefaultValue=false)]
        public string Credential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationPaymentType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
            sb.Append("  FundingSourceAffiliation: ").Append(FundingSourceAffiliation).Append("\n");
            sb.Append("  Credential: ").Append(Credential).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationPaymentType);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationPaymentType instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationPaymentType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationPaymentType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.FundingSource == other.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(other.FundingSource)
                ) && 
                (
                    this.FundingSourceAffiliation == other.FundingSourceAffiliation ||
                    this.FundingSourceAffiliation != null &&
                    this.FundingSourceAffiliation.Equals(other.FundingSourceAffiliation)
                ) && 
                (
                    this.Credential == other.Credential ||
                    this.Credential != null &&
                    this.Credential.Equals(other.Credential)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.FundingSource != null)
                    hash = hash * 59 + this.FundingSource.GetHashCode();
                if (this.FundingSourceAffiliation != null)
                    hash = hash * 59 + this.FundingSourceAffiliation.GetHashCode();
                if (this.Credential != null)
                    hash = hash * 59 + this.Credential.GetHashCode();
                return hash;
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