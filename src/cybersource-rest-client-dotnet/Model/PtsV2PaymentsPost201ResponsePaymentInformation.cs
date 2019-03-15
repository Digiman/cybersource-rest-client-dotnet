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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsPost201ResponsePaymentInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInformation :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInformation" /> class.
        /// </summary>
        /// <param name="Card">Card.</param>
        /// <param name="TokenizedCard">TokenizedCard.</param>
        /// <param name="AccountFeatures">AccountFeatures.</param>
        /// <param name="Bank">Bank.</param>
        public PtsV2PaymentsPost201ResponsePaymentInformation(PtsV2PaymentsPost201ResponsePaymentInformationCard Card = default(PtsV2PaymentsPost201ResponsePaymentInformationCard), PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard TokenizedCard = default(PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard), PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures AccountFeatures = default(PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures), PtsV2PaymentsPost201ResponsePaymentInformationBank Bank = default(PtsV2PaymentsPost201ResponsePaymentInformationBank))
        {
            this.Card = Card;
            this.TokenizedCard = TokenizedCard;
            this.AccountFeatures = AccountFeatures;
            this.Bank = Bank;
        }
        
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets TokenizedCard
        /// </summary>
        [DataMember(Name="tokenizedCard", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Gets or Sets AccountFeatures
        /// </summary>
        [DataMember(Name="accountFeatures", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures AccountFeatures { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInformationBank Bank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInformation {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  TokenizedCard: ").Append(TokenizedCard).Append("\n");
            sb.Append("  AccountFeatures: ").Append(AccountFeatures).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.TokenizedCard == other.TokenizedCard ||
                    this.TokenizedCard != null &&
                    this.TokenizedCard.Equals(other.TokenizedCard)
                ) && 
                (
                    this.AccountFeatures == other.AccountFeatures ||
                    this.AccountFeatures != null &&
                    this.AccountFeatures.Equals(other.AccountFeatures)
                ) && 
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
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
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.TokenizedCard != null)
                    hash = hash * 59 + this.TokenizedCard.GetHashCode();
                if (this.AccountFeatures != null)
                    hash = hash * 59 + this.AccountFeatures.GetHashCode();
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
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