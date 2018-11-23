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
    /// Ptsv2paymentsProcessingInformationAuthorizationOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessingInformationAuthorizationOptions :  IEquatable<Ptsv2paymentsProcessingInformationAuthorizationOptions>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeclineAvsFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeclineAvsFlagsEnum
        {
            
            /// <summary>
            /// Enum D for "D"
            /// </summary>
            [EnumMember(Value = "D")]
            D,
            
            /// <summary>
            /// Enum A for "A"
            /// </summary>
            [EnumMember(Value = "A")]
            A,
            
            /// <summary>
            /// Enum V for "V"
            /// </summary>
            [EnumMember(Value = "V")]
            V,
            
            /// <summary>
            /// Enum S for "S"
            /// </summary>
            [EnumMember(Value = "S")]
            S,
            
            /// <summary>
            /// Enum N for "N"
            /// </summary>
            [EnumMember(Value = "N")]
            N,
            
            /// <summary>
            /// Enum O for "O"
            /// </summary>
            [EnumMember(Value = "O")]
            O
        }

        /// <summary>
        /// An array of AVS flags that cause the reply flag to be returned.  &#x60;Important&#x60; To receive declines for the AVS code N, include the value N in the array. 
        /// </summary>
        /// <value>An array of AVS flags that cause the reply flag to be returned.  &#x60;Important&#x60; To receive declines for the AVS code N, include the value N in the array. </value>
        [DataMember(Name="declineAvsFlags", EmitDefaultValue=false)]
        public List<DeclineAvsFlagsEnum> DeclineAvsFlags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessingInformationAuthorizationOptions" /> class.
        /// </summary>
        /// <param name="AuthType">Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="VerbalAuthCode">Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="VerbalAuthTransactionId">Transaction ID (TID)..</param>
        /// <param name="AuthIndicator">Flag that specifies the purpose of the authorization.  Possible values:  - **0**: Preauthorization  - **1**: Final authorization  For processor-specific information, see the auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="PartialAuthIndicator">Flag that indicates whether the transaction is enabled for partial authorization or not. When your request includes this field, this value overrides the information in your CyberSource account.  For processor-specific information, see the auth_partial_auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="BalanceInquiry">Flag that indicates whether to return balance information..</param>
        /// <param name="IgnoreAvsResult">Flag that indicates whether to allow the capture service to run even when the payment receives an AVS decline.  (default to false).</param>
        /// <param name="DeclineAvsFlags">An array of AVS flags that cause the reply flag to be returned.  &#x60;Important&#x60; To receive declines for the AVS code N, include the value N in the array. .</param>
        /// <param name="IgnoreCvResult">Flag that indicates whether to allow the capture service to run even when the payment receives a CVN decline.  (default to false).</param>
        /// <param name="Initiator">Initiator.</param>
        public Ptsv2paymentsProcessingInformationAuthorizationOptions(string AuthType = default(string), string VerbalAuthCode = default(string), string VerbalAuthTransactionId = default(string), string AuthIndicator = default(string), bool? PartialAuthIndicator = default(bool?), bool? BalanceInquiry = default(bool?), bool? IgnoreAvsResult = false, List<DeclineAvsFlagsEnum> DeclineAvsFlags = default(List<DeclineAvsFlagsEnum>), bool? IgnoreCvResult = false, Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiator Initiator = default(Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiator))
        {
            this.AuthType = AuthType;
            this.VerbalAuthCode = VerbalAuthCode;
            this.VerbalAuthTransactionId = VerbalAuthTransactionId;
            this.AuthIndicator = AuthIndicator;
            this.PartialAuthIndicator = PartialAuthIndicator;
            this.BalanceInquiry = BalanceInquiry;
            // use default value if no "IgnoreAvsResult" provided
            if (IgnoreAvsResult == null)
            {
                this.IgnoreAvsResult = false;
            }
            else
            {
                this.IgnoreAvsResult = IgnoreAvsResult;
            }
            this.DeclineAvsFlags = DeclineAvsFlags;
            // use default value if no "IgnoreCvResult" provided
            if (IgnoreCvResult == null)
            {
                this.IgnoreCvResult = false;
            }
            else
            {
                this.IgnoreCvResult = IgnoreCvResult;
            }
            this.Initiator = Initiator;
        }
        
        /// <summary>
        /// Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Authorization type. Possible values:   - **AUTOCAPTURE**: automatic capture.  - **STANDARDCAPTURE**: standard capture.  - **VERBAL**: forced capture. Include it in the payment request for a forced capture. Include it in the capture  request for a verbal payment.  For processor-specific information, see the auth_type field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Authorization code.  **Forced Capture**  Use this field to send the authorization code you received from a payment that you authorized outside the CyberSource system.  **Verbal Authorization**  Use this field in CAPTURE API to send the verbally received authorization code.  For processor-specific information, see the auth_code field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="verbalAuthCode", EmitDefaultValue=false)]
        public string VerbalAuthCode { get; set; }

        /// <summary>
        /// Transaction ID (TID).
        /// </summary>
        /// <value>Transaction ID (TID).</value>
        [DataMember(Name="verbalAuthTransactionId", EmitDefaultValue=false)]
        public string VerbalAuthTransactionId { get; set; }

        /// <summary>
        /// Flag that specifies the purpose of the authorization.  Possible values:  - **0**: Preauthorization  - **1**: Final authorization  For processor-specific information, see the auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that specifies the purpose of the authorization.  Possible values:  - **0**: Preauthorization  - **1**: Final authorization  For processor-specific information, see the auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="authIndicator", EmitDefaultValue=false)]
        public string AuthIndicator { get; set; }

        /// <summary>
        /// Flag that indicates whether the transaction is enabled for partial authorization or not. When your request includes this field, this value overrides the information in your CyberSource account.  For processor-specific information, see the auth_partial_auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that indicates whether the transaction is enabled for partial authorization or not. When your request includes this field, this value overrides the information in your CyberSource account.  For processor-specific information, see the auth_partial_auth_indicator field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="partialAuthIndicator", EmitDefaultValue=false)]
        public bool? PartialAuthIndicator { get; set; }

        /// <summary>
        /// Flag that indicates whether to return balance information.
        /// </summary>
        /// <value>Flag that indicates whether to return balance information.</value>
        [DataMember(Name="balanceInquiry", EmitDefaultValue=false)]
        public bool? BalanceInquiry { get; set; }

        /// <summary>
        /// Flag that indicates whether to allow the capture service to run even when the payment receives an AVS decline. 
        /// </summary>
        /// <value>Flag that indicates whether to allow the capture service to run even when the payment receives an AVS decline. </value>
        [DataMember(Name="ignoreAvsResult", EmitDefaultValue=false)]
        public bool? IgnoreAvsResult { get; set; }


        /// <summary>
        /// Flag that indicates whether to allow the capture service to run even when the payment receives a CVN decline. 
        /// </summary>
        /// <value>Flag that indicates whether to allow the capture service to run even when the payment receives a CVN decline. </value>
        [DataMember(Name="ignoreCvResult", EmitDefaultValue=false)]
        public bool? IgnoreCvResult { get; set; }

        /// <summary>
        /// Gets or Sets Initiator
        /// </summary>
        [DataMember(Name="initiator", EmitDefaultValue=false)]
        public Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiator Initiator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessingInformationAuthorizationOptions {\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  VerbalAuthCode: ").Append(VerbalAuthCode).Append("\n");
            sb.Append("  VerbalAuthTransactionId: ").Append(VerbalAuthTransactionId).Append("\n");
            sb.Append("  AuthIndicator: ").Append(AuthIndicator).Append("\n");
            sb.Append("  PartialAuthIndicator: ").Append(PartialAuthIndicator).Append("\n");
            sb.Append("  BalanceInquiry: ").Append(BalanceInquiry).Append("\n");
            sb.Append("  IgnoreAvsResult: ").Append(IgnoreAvsResult).Append("\n");
            sb.Append("  DeclineAvsFlags: ").Append(DeclineAvsFlags).Append("\n");
            sb.Append("  IgnoreCvResult: ").Append(IgnoreCvResult).Append("\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessingInformationAuthorizationOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessingInformationAuthorizationOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessingInformationAuthorizationOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessingInformationAuthorizationOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthType == other.AuthType ||
                    this.AuthType != null &&
                    this.AuthType.Equals(other.AuthType)
                ) && 
                (
                    this.VerbalAuthCode == other.VerbalAuthCode ||
                    this.VerbalAuthCode != null &&
                    this.VerbalAuthCode.Equals(other.VerbalAuthCode)
                ) && 
                (
                    this.VerbalAuthTransactionId == other.VerbalAuthTransactionId ||
                    this.VerbalAuthTransactionId != null &&
                    this.VerbalAuthTransactionId.Equals(other.VerbalAuthTransactionId)
                ) && 
                (
                    this.AuthIndicator == other.AuthIndicator ||
                    this.AuthIndicator != null &&
                    this.AuthIndicator.Equals(other.AuthIndicator)
                ) && 
                (
                    this.PartialAuthIndicator == other.PartialAuthIndicator ||
                    this.PartialAuthIndicator != null &&
                    this.PartialAuthIndicator.Equals(other.PartialAuthIndicator)
                ) && 
                (
                    this.BalanceInquiry == other.BalanceInquiry ||
                    this.BalanceInquiry != null &&
                    this.BalanceInquiry.Equals(other.BalanceInquiry)
                ) && 
                (
                    this.IgnoreAvsResult == other.IgnoreAvsResult ||
                    this.IgnoreAvsResult != null &&
                    this.IgnoreAvsResult.Equals(other.IgnoreAvsResult)
                ) && 
                (
                    this.DeclineAvsFlags == other.DeclineAvsFlags ||
                    this.DeclineAvsFlags != null &&
                    this.DeclineAvsFlags.SequenceEqual(other.DeclineAvsFlags)
                ) && 
                (
                    this.IgnoreCvResult == other.IgnoreCvResult ||
                    this.IgnoreCvResult != null &&
                    this.IgnoreCvResult.Equals(other.IgnoreCvResult)
                ) && 
                (
                    this.Initiator == other.Initiator ||
                    this.Initiator != null &&
                    this.Initiator.Equals(other.Initiator)
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
                if (this.AuthType != null)
                    hash = hash * 59 + this.AuthType.GetHashCode();
                if (this.VerbalAuthCode != null)
                    hash = hash * 59 + this.VerbalAuthCode.GetHashCode();
                if (this.VerbalAuthTransactionId != null)
                    hash = hash * 59 + this.VerbalAuthTransactionId.GetHashCode();
                if (this.AuthIndicator != null)
                    hash = hash * 59 + this.AuthIndicator.GetHashCode();
                if (this.PartialAuthIndicator != null)
                    hash = hash * 59 + this.PartialAuthIndicator.GetHashCode();
                if (this.BalanceInquiry != null)
                    hash = hash * 59 + this.BalanceInquiry.GetHashCode();
                if (this.IgnoreAvsResult != null)
                    hash = hash * 59 + this.IgnoreAvsResult.GetHashCode();
                if (this.DeclineAvsFlags != null)
                    hash = hash * 59 + this.DeclineAvsFlags.GetHashCode();
                if (this.IgnoreCvResult != null)
                    hash = hash * 59 + this.IgnoreCvResult.GetHashCode();
                if (this.Initiator != null)
                    hash = hash * 59 + this.Initiator.GetHashCode();
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
            // AuthType (string) maxLength
            if(this.AuthType != null && this.AuthType.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthType, length must be less than 15.", new [] { "AuthType" });
            }

            // VerbalAuthCode (string) maxLength
            if(this.VerbalAuthCode != null && this.VerbalAuthCode.Length > 7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VerbalAuthCode, length must be less than 7.", new [] { "VerbalAuthCode" });
            }

            // VerbalAuthTransactionId (string) maxLength
            if(this.VerbalAuthTransactionId != null && this.VerbalAuthTransactionId.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VerbalAuthTransactionId, length must be less than 15.", new [] { "VerbalAuthTransactionId" });
            }

            // AuthIndicator (string) maxLength
            if(this.AuthIndicator != null && this.AuthIndicator.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthIndicator, length must be less than 1.", new [] { "AuthIndicator" });
            }

            yield break;
        }
    }

}