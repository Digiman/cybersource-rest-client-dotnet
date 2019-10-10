# CyberSource.Model.TssV2TransactionsGet200ResponsePaymentInformationPaymentType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A Payment Type is an agreed means for a payee to receive legal tender from a payer. The way one pays for a commercial financial transaction. Examples: Card, Bank Transfer, Digital, Direct Debit. Possible values: - &#x60;CARD&#x60; (use this for a PIN debit transaction)  | [optional] 
**SubTypeName** | **string** | SubType Name is detail information about Payment Type. Examples: For Card, if Credit or Debit or PrePaid. For Bank Transfer, if Online Bank Transfer or Wire Transfers. - &#x60;DEBIT&#x60; (use this for a PIN debit transaction)  | [optional] 
**FundingSource** | [**TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeFundingSource**](TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeFundingSource.md) |  | [optional] 
**Method** | **string** | A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal | [optional] 
**AuthenticationMethod** | **string** | A Payment Type Authentication Method is the means used to verify that the presenter of the Payment Type credential is an authorized user of the Payment Instrument. Examples: 3DSecure – Verified by Visa, 3DSecure – MasteCard Secure Code  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

