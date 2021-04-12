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
    public class WarehouseT
    {
        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "IsSystem", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSystem")]
        public bool? IsSystem { get; set; }

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
        /// Gets or Sets TenantLocationID
        /// </summary>
        [DataMember(Name = "TenantLocationID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TenantLocationID")]
        public int? TenantLocationID { get; set; }

        /// <summary>
        /// Gets or Sets TenantLocationName
        /// </summary>
        [DataMember(Name = "TenantLocationName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TenantLocationName")]
        public string TenantLocationName { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseTypeID
        /// </summary>
        [DataMember(Name = "WarehouseTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseTypeID")]
        public int? WarehouseTypeID { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "Code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

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
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name = "Barcode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "IsDefault", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets SyncLogs
        /// </summary>
        [DataMember(Name = "SyncLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SyncLogs")]
        public List<SyncLogT> SyncLogs { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "Location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Location")]
        public LocationT Location { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseType
        /// </summary>
        [DataMember(Name = "WarehouseType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WarehouseType")]
        public WarehouseTypeT WarehouseType { get; set; }

        /// <summary>
        /// Gets or Sets TotalNumberOfDistinctProducts
        /// </summary>
        [DataMember(Name = "TotalNumberOfDistinctProducts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TotalNumberOfDistinctProducts")]
        public long? TotalNumberOfDistinctProducts { get; set; }

        /// <summary>
        /// Gets or Sets TotalSOH
        /// </summary>
        [DataMember(Name = "TotalSOH", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TotalSOH")]
        public double? TotalSOH { get; set; }

        /// <summary>
        /// Gets or Sets TotalStockValue
        /// </summary>
        [DataMember(Name = "TotalStockValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TotalStockValue")]
        public double? TotalStockValue { get; set; }

        /// <summary>
        /// Gets or Sets IsStockOpeningBalanceComplete
        /// </summary>
        [DataMember(Name = "IsStockOpeningBalanceComplete", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsStockOpeningBalanceComplete")]
        public bool? IsStockOpeningBalanceComplete { get; set; }

        /// <summary>
        /// Gets or Sets MinimumStockHoldingValue
        /// </summary>
        [DataMember(Name = "MinimumStockHoldingValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MinimumStockHoldingValue")]
        public double? MinimumStockHoldingValue { get; set; }

        /// <summary>
        /// Gets or Sets MaximumStockHoldingValue
        /// </summary>
        [DataMember(Name = "MaximumStockHoldingValue", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MaximumStockHoldingValue")]
        public double? MaximumStockHoldingValue { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPOSCustomerID
        /// </summary>
        [DataMember(Name = "DefaultPOSCustomerID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DefaultPOSCustomerID")]
        public int? DefaultPOSCustomerID { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPOSCustomerName
        /// </summary>
        [DataMember(Name = "DefaultPOSCustomerName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DefaultPOSCustomerName")]
        public string DefaultPOSCustomerName { get; set; }

        /// <summary>
        /// Gets or Sets CostCentreCode
        /// </summary>
        [DataMember(Name = "CostCentreCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CostCentreCode")]
        public string CostCentreCode { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "Users", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Users")]
        public List<UserT> Users { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarehouseT {\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  BSID: ").Append(BSID).Append("\n");
            sb.Append("  TenantLocationID: ").Append(TenantLocationID).Append("\n");
            sb.Append("  TenantLocationName: ").Append(TenantLocationName).Append("\n");
            sb.Append("  WarehouseTypeID: ").Append(WarehouseTypeID).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  WarehouseType: ").Append(WarehouseType).Append("\n");
            sb.Append("  TotalNumberOfDistinctProducts: ").Append(TotalNumberOfDistinctProducts).Append("\n");
            sb.Append("  TotalSOH: ").Append(TotalSOH).Append("\n");
            sb.Append("  TotalStockValue: ").Append(TotalStockValue).Append("\n");
            sb.Append("  IsStockOpeningBalanceComplete: ").Append(IsStockOpeningBalanceComplete).Append("\n");
            sb.Append("  MinimumStockHoldingValue: ").Append(MinimumStockHoldingValue).Append("\n");
            sb.Append("  MaximumStockHoldingValue: ").Append(MaximumStockHoldingValue).Append("\n");
            sb.Append("  DefaultPOSCustomerID: ").Append(DefaultPOSCustomerID).Append("\n");
            sb.Append("  DefaultPOSCustomerName: ").Append(DefaultPOSCustomerName).Append("\n");
            sb.Append("  CostCentreCode: ").Append(CostCentreCode).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
