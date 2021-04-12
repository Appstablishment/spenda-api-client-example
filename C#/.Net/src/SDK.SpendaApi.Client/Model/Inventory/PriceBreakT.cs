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
    public class PriceBreakT
    {
        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name = "TaxRate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TaxRate")]
        public double? TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets IsOrderTaxExempt
        /// </summary>
        [DataMember(Name = "IsOrderTaxExempt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsOrderTaxExempt")]
        public bool? IsOrderTaxExempt { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets StandardSellPriceEx
        /// </summary>
        [DataMember(Name = "StandardSellPriceEx", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "StandardSellPriceEx")]
        public double? StandardSellPriceEx { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name = "Rule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Rule")]
        public string Rule { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "CurrencyCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CurrencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MinQty
        /// </summary>
        [DataMember(Name = "MinQty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MinQty")]
        public double? MinQty { get; set; }

        /// <summary>
        /// Gets or Sets MaxQty
        /// </summary>
        [DataMember(Name = "MaxQty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MaxQty")]
        public double? MaxQty { get; set; }

        /// <summary>
        /// Gets or Sets PriceInc
        /// </summary>
        [DataMember(Name = "PriceInc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PriceInc")]
        public double? PriceInc { get; set; }

        /// <summary>
        /// Gets or Sets PriceTax
        /// </summary>
        [DataMember(Name = "PriceTax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PriceTax")]
        public double? PriceTax { get; set; }

        /// <summary>
        /// Gets or Sets PriceEx
        /// </summary>
        [DataMember(Name = "PriceEx", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PriceEx")]
        public double? PriceEx { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceBreakT {\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  IsOrderTaxExempt: ").Append(IsOrderTaxExempt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StandardSellPriceEx: ").Append(StandardSellPriceEx).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MinQty: ").Append(MinQty).Append("\n");
            sb.Append("  MaxQty: ").Append(MaxQty).Append("\n");
            sb.Append("  PriceInc: ").Append(PriceInc).Append("\n");
            sb.Append("  PriceTax: ").Append(PriceTax).Append("\n");
            sb.Append("  PriceEx: ").Append(PriceEx).Append("\n");
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
