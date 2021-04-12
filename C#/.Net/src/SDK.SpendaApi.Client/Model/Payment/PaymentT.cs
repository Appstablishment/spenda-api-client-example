using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SDK.SpendaApi.Client.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class PaymentT
    {
        /// <summary>
        /// Gets or Sets RowNumber
        /// </summary>
        [DataMember(Name = "RowNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RowNumber")]
        public long? RowNumber { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Version")]
        public double? Version { get; set; }

        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        [DataMember(Name = "GUID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUID")]
        public Guid? GUID { get; set; }

        /// <summary>
        /// Gets or Sets AmountString
        /// </summary>
        [DataMember(Name = "AmountString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AmountString")]
        public string AmountString { get; set; }

        /// <summary>
        /// Gets or Sets AmountTenderedString
        /// </summary>
        [DataMember(Name = "AmountTenderedString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AmountTenderedString")]
        public string AmountTenderedString { get; set; }

        /// <summary>
        /// Gets or Sets ChangeGivenString
        /// </summary>
        [DataMember(Name = "ChangeGivenString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ChangeGivenString")]
        public string ChangeGivenString { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeString
        /// </summary>
        [DataMember(Name = "DateTimeString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DateTimeString")]
        public string DateTimeString { get; set; }

        /// <summary>
        /// Gets or Sets DateString
        /// </summary>
        [DataMember(Name = "DateString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DateString")]
        public string DateString { get; set; }

        /// <summary>
        /// Gets or Sets DocID
        /// </summary>
        [DataMember(Name = "DocID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DocID")]
        public int? DocID { get; set; }

        /// <summary>
        /// Gets or Sets DatTypeID
        /// </summary>
        [DataMember(Name = "DatTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DatTypeID")]
        public int? DatTypeID { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "ErrorMessage", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets FeeString
        /// </summary>
        [DataMember(Name = "FeeString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "FeeString")]
        public string FeeString { get; set; }

        /// <summary>
        /// Gets or Sets IsGiftCard
        /// </summary>
        [DataMember(Name = "IsGiftCard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsGiftCard")]
        public bool? IsGiftCard { get; set; }

        /// <summary>
        /// Gets or Sets IsPaid
        /// </summary>
        [DataMember(Name = "IsPaid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsPaid")]
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Gets or Sets POSTerminalShiftID
        /// </summary>
        [DataMember(Name = "POSTerminalShiftID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "POSTerminalShiftID")]
        public int? POSTerminalShiftID { get; set; }

        /// <summary>
        /// Gets or Sets POSDeviceID
        /// </summary>
        [DataMember(Name = "POSDeviceID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "POSDeviceID")]
        public string POSDeviceID { get; set; }

        /// <summary>
        /// Gets or Sets AccountCustomerRefNumber
        /// </summary>
        [DataMember(Name = "AccountCustomerRefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AccountCustomerRefNumber")]
        public string AccountCustomerRefNumber { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDeviceID
        /// </summary>
        [DataMember(Name = "PaymentDeviceID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentDeviceID")]
        public string PaymentDeviceID { get; set; }

        /// <summary>
        /// Gets or Sets MerchantID
        /// </summary>
        [DataMember(Name = "MerchantID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MerchantID")]
        public string MerchantID { get; set; }

        /// <summary>
        /// Gets or Sets TerminalType
        /// </summary>
        [DataMember(Name = "TerminalType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TerminalType")]
        public string TerminalType { get; set; }

        /// <summary>
        /// Gets or Sets SurchargeAmount
        /// </summary>
        [DataMember(Name = "SurchargeAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SurchargeAmount")]
        public double? SurchargeAmount { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        [DataMember(Name = "SettlementDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SettlementDate")]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets IsManualSettlementDate
        /// </summary>
        [DataMember(Name = "IsManualSettlementDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsManualSettlementDate")]
        public bool? IsManualSettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Gets or Sets GUIDstring
        /// </summary>
        [DataMember(Name = "GUIDstring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUIDstring")]
        public string GUIDstring { get; set; }

        /// <summary>
        /// Gets or Sets BSID
        /// </summary>
        [DataMember(Name = "BSID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "BSID")]
        public string BSID { get; set; }

        /// <summary>
        /// Gets or Sets MethodID
        /// </summary>
        [DataMember(Name = "MethodID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MethodID")]
        public int? MethodID { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "Method", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "Currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "Fee", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Fee")]
        public double? Fee { get; set; }

        /// <summary>
        /// Gets or Sets AmountTendered
        /// </summary>
        [DataMember(Name = "AmountTendered", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AmountTendered")]
        public double? AmountTendered { get; set; }

        /// <summary>
        /// Gets or Sets ChangeGiven
        /// </summary>
        [DataMember(Name = "ChangeGiven", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ChangeGiven")]
        public double? ChangeGiven { get; set; }

        /// <summary>
        /// Gets or Sets CashOut
        /// </summary>
        [DataMember(Name = "CashOut", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CashOut")]
        public double? CashOut { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name = "DateTime", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDateTimeUtc
        /// </summary>
        [DataMember(Name = "PaymentDateTime_utc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentDateTime_utc")]
        public DateTime? PaymentDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDateTimeOffset
        /// </summary>
        [DataMember(Name = "PaymentDateTime_offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentDateTime_offset")]
        public int? PaymentDateTimeOffset { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "Token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Token")]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets RefNumber
        /// </summary>
        [DataMember(Name = "RefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RefNumber")]
        public string RefNumber { get; set; }

        /// <summary>
        /// Gets or Sets TransRefNumber
        /// </summary>
        [DataMember(Name = "TransRefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransRefNumber")]
        public string TransRefNumber { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransactionType")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets TransactionTypeDatTypeID
        /// </summary>
        [DataMember(Name = "TransactionTypeDatTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransactionTypeDatTypeID")]
        public int? TransactionTypeDatTypeID { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptID
        /// </summary>
        [DataMember(Name = "ReceiptID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ReceiptID")]
        public string ReceiptID { get; set; }

        /// <summary>
        /// Gets or Sets ChequeNumber
        /// </summary>
        [DataMember(Name = "ChequeNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ChequeNumber")]
        public string ChequeNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountCode
        /// </summary>
        [DataMember(Name = "AccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AccountCode")]
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountCode
        /// </summary>
        [DataMember(Name = "BankAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "BankAccountCode")]
        public string BankAccountCode { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name = "ExchangeRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ExchangeRate")]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets AppliedAmount
        /// </summary>
        [DataMember(Name = "AppliedAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedAmount")]
        public double? AppliedAmount { get; set; }

        /// <summary>
        /// Gets or Sets AppliedDate
        /// </summary>
        [DataMember(Name = "AppliedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedDate")]
        public DateTime? AppliedDate { get; set; }

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name = "CustomerID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CustomerID")]
        public int? CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGUIDstring
        /// </summary>
        [DataMember(Name = "CustomerGUIDstring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CustomerGUIDstring")]
        public string CustomerGUIDstring { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "CustomerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CustomerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerBSID
        /// </summary>
        [DataMember(Name = "CustomerBSID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CustomerBSID")]
        public string CustomerBSID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerRefNumber
        /// </summary>
        [DataMember(Name = "CustomerRefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CustomerRefNumber")]
        public string CustomerRefNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountCustomerID
        /// </summary>
        [DataMember(Name = "AccountCustomerID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AccountCustomerID")]
        public int? AccountCustomerID { get; set; }

        /// <summary>
        /// Gets or Sets AccountCustomerName
        /// </summary>
        [DataMember(Name = "AccountCustomerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AccountCustomerName")]
        public string AccountCustomerName { get; set; }

        /// <summary>
        /// Gets or Sets IsAccountCustomer
        /// </summary>
        [DataMember(Name = "IsAccountCustomer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsAccountCustomer")]
        public bool? IsAccountCustomer { get; set; }

        /// <summary>
        /// Gets or Sets SupplierID
        /// </summary>
        [DataMember(Name = "SupplierID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SupplierID")]
        public int? SupplierID { get; set; }

        /// <summary>
        /// Gets or Sets SupplierGUIDstring
        /// </summary>
        [DataMember(Name = "SupplierGUIDstring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SupplierGUIDstring")]
        public string SupplierGUIDstring { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name = "SupplierName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SupplierName")]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets SupplierBSID
        /// </summary>
        [DataMember(Name = "SupplierBSID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SupplierBSID")]
        public string SupplierBSID { get; set; }

        /// <summary>
        /// Gets or Sets SupplierRefNumber
        /// </summary>
        [DataMember(Name = "SupplierRefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SupplierRefNumber")]
        public string SupplierRefNumber { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsRefund
        /// </summary>
        [DataMember(Name = "IsRefund", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsRefund")]
        public bool? IsRefund { get; set; }

        /// <summary>
        /// Gets or Sets IsRefunded
        /// </summary>
        [DataMember(Name = "IsRefunded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsRefunded")]
        public bool? IsRefunded { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPaymentID
        /// </summary>
        [DataMember(Name = "OriginalPaymentID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "OriginalPaymentID")]
        public int? OriginalPaymentID { get; set; }

        /// <summary>
        /// Gets or Sets RepFirstName
        /// </summary>
        [DataMember(Name = "RepFirstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RepFirstName")]
        public string RepFirstName { get; set; }

        /// <summary>
        /// Gets or Sets RepLastName
        /// </summary>
        [DataMember(Name = "RepLastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RepLastName")]
        public string RepLastName { get; set; }

        /// <summary>
        /// Gets or Sets RepEmailAddress
        /// </summary>
        [DataMember(Name = "RepEmailAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RepEmailAddress")]
        public string RepEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets RepUserName
        /// </summary>
        [DataMember(Name = "RepUserName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RepUserName")]
        public string RepUserName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedWith
        /// </summary>
        [DataMember(Name = "CreatedWith", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CreatedWith")]
        public string CreatedWith { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "Balance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or Sets IsManuallyAllocated
        /// </summary>
        [DataMember(Name = "IsManuallyAllocated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsManuallyAllocated")]
        public bool? IsManuallyAllocated { get; set; }

        /// <summary>
        /// Gets or Sets TerminalID
        /// </summary>
        [DataMember(Name = "TerminalID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TerminalID")]
        public string TerminalID { get; set; }

        /// <summary>
        /// Gets or Sets RefBusTrans
        /// </summary>
        [DataMember(Name = "RefBusTrans", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RefBusTrans")]
        public List<RefBusTranT> RefBusTrans { get; set; }

        /// <summary>
        /// Gets or Sets SyncLogs
        /// </summary>
        [DataMember(Name = "SyncLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SyncLogs")]
        public List<SyncLogT> SyncLogs { get; set; }

        /// <summary>
        /// Gets or Sets CreditCard
        /// </summary>
        [DataMember(Name = "CreditCard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CreditCard")]
        public CreditCardT CreditCard { get; set; }

        /// <summary>
        /// Gets or Sets PaymentLogs
        /// </summary>
        [DataMember(Name = "PaymentLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentLogs")]
        public List<PaymentLogT> PaymentLogs { get; set; }

        /// <summary>
        /// Gets or Sets PaymentService
        /// </summary>
        [DataMember(Name = "PaymentService", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentService")]
        public string PaymentService { get; set; }

        /// <summary>
        /// Gets or Sets PaymentServiceMerchantID
        /// </summary>
        [DataMember(Name = "PaymentServiceMerchantID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentServiceMerchantID")]
        public string PaymentServiceMerchantID { get; set; }

        /// <summary>
        /// Gets or Sets PaymentServiceTerminalID
        /// </summary>
        [DataMember(Name = "PaymentServiceTerminalID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PaymentServiceTerminalID")]
        public string PaymentServiceTerminalID { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentT {\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  GUID: ").Append(GUID).Append("\n");
            sb.Append("  AmountString: ").Append(AmountString).Append("\n");
            sb.Append("  AmountTenderedString: ").Append(AmountTenderedString).Append("\n");
            sb.Append("  ChangeGivenString: ").Append(ChangeGivenString).Append("\n");
            sb.Append("  DateTimeString: ").Append(DateTimeString).Append("\n");
            sb.Append("  DateString: ").Append(DateString).Append("\n");
            sb.Append("  DocID: ").Append(DocID).Append("\n");
            sb.Append("  DatTypeID: ").Append(DatTypeID).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  FeeString: ").Append(FeeString).Append("\n");
            sb.Append("  IsGiftCard: ").Append(IsGiftCard).Append("\n");
            sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
            sb.Append("  POSTerminalShiftID: ").Append(POSTerminalShiftID).Append("\n");
            sb.Append("  POSDeviceID: ").Append(POSDeviceID).Append("\n");
            sb.Append("  AccountCustomerRefNumber: ").Append(AccountCustomerRefNumber).Append("\n");
            sb.Append("  PaymentDeviceID: ").Append(PaymentDeviceID).Append("\n");
            sb.Append("  MerchantID: ").Append(MerchantID).Append("\n");
            sb.Append("  TerminalType: ").Append(TerminalType).Append("\n");
            sb.Append("  SurchargeAmount: ").Append(SurchargeAmount).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  IsManualSettlementDate: ").Append(IsManualSettlementDate).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  BSID: ").Append(BSID).Append("\n");
            sb.Append("  MethodID: ").Append(MethodID).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  AmountTendered: ").Append(AmountTendered).Append("\n");
            sb.Append("  ChangeGiven: ").Append(ChangeGiven).Append("\n");
            sb.Append("  CashOut: ").Append(CashOut).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  PaymentDateTimeUtc: ").Append(PaymentDateTimeUtc).Append("\n");
            sb.Append("  PaymentDateTimeOffset: ").Append(PaymentDateTimeOffset).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
            sb.Append("  TransRefNumber: ").Append(TransRefNumber).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  TransactionTypeDatTypeID: ").Append(TransactionTypeDatTypeID).Append("\n");
            sb.Append("  ReceiptID: ").Append(ReceiptID).Append("\n");
            sb.Append("  ChequeNumber: ").Append(ChequeNumber).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  BankAccountCode: ").Append(BankAccountCode).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
            sb.Append("  AppliedDate: ").Append(AppliedDate).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  CustomerGUIDstring: ").Append(CustomerGUIDstring).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  CustomerBSID: ").Append(CustomerBSID).Append("\n");
            sb.Append("  CustomerRefNumber: ").Append(CustomerRefNumber).Append("\n");
            sb.Append("  AccountCustomerID: ").Append(AccountCustomerID).Append("\n");
            sb.Append("  AccountCustomerName: ").Append(AccountCustomerName).Append("\n");
            sb.Append("  IsAccountCustomer: ").Append(IsAccountCustomer).Append("\n");
            sb.Append("  SupplierID: ").Append(SupplierID).Append("\n");
            sb.Append("  SupplierGUIDstring: ").Append(SupplierGUIDstring).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  SupplierBSID: ").Append(SupplierBSID).Append("\n");
            sb.Append("  SupplierRefNumber: ").Append(SupplierRefNumber).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsRefund: ").Append(IsRefund).Append("\n");
            sb.Append("  IsRefunded: ").Append(IsRefunded).Append("\n");
            sb.Append("  OriginalPaymentID: ").Append(OriginalPaymentID).Append("\n");
            sb.Append("  RepFirstName: ").Append(RepFirstName).Append("\n");
            sb.Append("  RepLastName: ").Append(RepLastName).Append("\n");
            sb.Append("  RepEmailAddress: ").Append(RepEmailAddress).Append("\n");
            sb.Append("  RepUserName: ").Append(RepUserName).Append("\n");
            sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  IsManuallyAllocated: ").Append(IsManuallyAllocated).Append("\n");
            sb.Append("  TerminalID: ").Append(TerminalID).Append("\n");
            sb.Append("  RefBusTrans: ").Append(RefBusTrans).Append("\n");
            sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
            sb.Append("  CreditCard: ").Append(CreditCard).Append("\n");
            sb.Append("  PaymentLogs: ").Append(PaymentLogs).Append("\n");
            sb.Append("  PaymentService: ").Append(PaymentService).Append("\n");
            sb.Append("  PaymentServiceMerchantID: ").Append(PaymentServiceMerchantID).Append("\n");
            sb.Append("  PaymentServiceTerminalID: ").Append(PaymentServiceTerminalID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
