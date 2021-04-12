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
    public class StockOnHandT
    {
        /// <summary>
        /// Gets or Sets WarehouseBSID
        /// </summary>
        [DataMember(Name = "WarehouseBSID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseBSID")]
        public string WarehouseBSID { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseSourceBSID
        /// </summary>
        [DataMember(Name = "WarehouseSourceBSID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseSourceBSID")]
        public string WarehouseSourceBSID { get; set; }

        /// <summary>
        /// Gets or Sets OnHand
        /// </summary>
        [DataMember(Name = "OnHand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "OnHand")]
        public double? OnHand { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StockOnHandT {\n");
            sb.Append("  WarehouseBSID: ").Append(WarehouseBSID).Append("\n");
            sb.Append("  WarehouseSourceBSID: ").Append(WarehouseSourceBSID).Append("\n");
            sb.Append("  OnHand: ").Append(OnHand).Append("\n");
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
