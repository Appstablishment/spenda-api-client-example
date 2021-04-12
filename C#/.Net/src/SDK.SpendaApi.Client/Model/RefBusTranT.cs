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
    public class RefBusTranT
    {
        /// <summary>
        /// Gets or Sets AmountString
        /// </summary>
        [DataMember(Name = "AmountString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AmountString")]
        public string AmountString { get; set; }

        /// <summary>
        /// Gets or Sets AppliedAmountString
        /// </summary>
        [DataMember(Name = "AppliedAmountString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedAmountString")]
        public string AppliedAmountString { get; set; }

        /// <summary>
        /// Gets or Sets AppliedDateString
        /// </summary>
        [DataMember(Name = "AppliedDateString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedDateString")]
        public string AppliedDateString { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "Summary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        [DataMember(Name = "GUID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUID")]
        public Guid? GUID { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TotalInc
        /// </summary>
        [DataMember(Name = "TotalInc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TotalInc")]
        public double? TotalInc { get; set; }

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
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets TransTypeID
        /// </summary>
        [DataMember(Name = "TransTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransTypeID")]
        public int? TransTypeID { get; set; }

        /// <summary>
        /// Gets or Sets TransType
        /// </summary>
        [DataMember(Name = "TransType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransType")]
        public string TransType { get; set; }

        /// <summary>
        /// Gets or Sets RefNumber
        /// </summary>
        [DataMember(Name = "RefNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "RefNumber")]
        public string RefNumber { get; set; }

        /// <summary>
        /// Gets or Sets AppliedDate
        /// </summary>
        [DataMember(Name = "AppliedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedDate")]
        public DateTime? AppliedDate { get; set; }

        /// <summary>
        /// Gets or Sets AppliedAmount
        /// </summary>
        [DataMember(Name = "AppliedAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AppliedAmount")]
        public double? AppliedAmount { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "Balance", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// Gets or Sets MerchantSurcharge
        /// </summary>
        [DataMember(Name = "MerchantSurcharge", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MerchantSurcharge")]
        public double? MerchantSurcharge { get; set; }

        /// <summary>
        /// Gets or Sets MerchantSurchargeLineID
        /// </summary>
        [DataMember(Name = "MerchantSurchargeLineID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MerchantSurchargeLineID")]
        public int? MerchantSurchargeLineID { get; set; }

        /// <summary>
        /// Gets or Sets TransSubType
        /// </summary>
        [DataMember(Name = "TransSubType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransSubType")]
        public string TransSubType { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefBusTranT {\n");
            sb.Append("  AmountString: ").Append(AmountString).Append("\n");
            sb.Append("  AppliedAmountString: ").Append(AppliedAmountString).Append("\n");
            sb.Append("  AppliedDateString: ").Append(AppliedDateString).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  GUID: ").Append(GUID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalInc: ").Append(TotalInc).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  BSID: ").Append(BSID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TransTypeID: ").Append(TransTypeID).Append("\n");
            sb.Append("  TransType: ").Append(TransType).Append("\n");
            sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
            sb.Append("  AppliedDate: ").Append(AppliedDate).Append("\n");
            sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  MerchantSurcharge: ").Append(MerchantSurcharge).Append("\n");
            sb.Append("  MerchantSurchargeLineID: ").Append(MerchantSurchargeLineID).Append("\n");
            sb.Append("  TransSubType: ").Append(TransSubType).Append("\n");
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
