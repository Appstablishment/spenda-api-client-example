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
    public class WarehouseLocationInfo
    {
        /// <summary>
        /// Gets or Sets WarehouseLocationID
        /// </summary>
        [DataMember(Name = "WarehouseLocationID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseLocationID")]
        public int? WarehouseLocationID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name = "WarehouseID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseID")]
        public int? WarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "Barcode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseLocationTypeID
        /// </summary>
        [DataMember(Name = "WarehouseLocationTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseLocationTypeID")]
        public int? WarehouseLocationTypeID { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseTypeName
        /// </summary>
        [DataMember(Name = "WarehouseTypeName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseTypeName")]
        public string WarehouseTypeName { get; set; }

        /// <summary>
        /// Gets or Sets AlreadyExists
        /// </summary>
        [DataMember(Name = "AlreadyExists", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AlreadyExists")]
        public bool? AlreadyExists { get; set; }

        /// <summary>
        /// Gets or Sets SOH
        /// </summary>
        [DataMember(Name = "SOH", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SOH")]
        public double? SOH { get; set; }

        /// <summary>
        /// Gets or Sets ExcludePickAndPack
        /// </summary>
        [DataMember(Name = "ExcludePickAndPack", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ExcludePickAndPack")]
        public bool? ExcludePickAndPack { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets SerialisedAssetCount
        /// </summary>
        [DataMember(Name = "SerialisedAssetCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SerialisedAssetCount")]
        public int? SerialisedAssetCount { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "IsSystem", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSystem")]
        public bool? IsSystem { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarehouseLocationInfo {\n");
            sb.Append("  WarehouseLocationID: ").Append(WarehouseLocationID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  WarehouseLocationTypeID: ").Append(WarehouseLocationTypeID).Append("\n");
            sb.Append("  WarehouseTypeName: ").Append(WarehouseTypeName).Append("\n");
            sb.Append("  AlreadyExists: ").Append(AlreadyExists).Append("\n");
            sb.Append("  SOH: ").Append(SOH).Append("\n");
            sb.Append("  ExcludePickAndPack: ").Append(ExcludePickAndPack).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SerialisedAssetCount: ").Append(SerialisedAssetCount).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
