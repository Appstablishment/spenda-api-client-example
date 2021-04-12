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
    public class InventoryClassT
    {
        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        [DataMember(Name = "GUID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUID")]
        public Guid? GUID { get; set; }

        /// <summary>
        /// Gets or Sets SalesPostingInventoryCode
        /// </summary>
        [DataMember(Name = "SalesPostingInventoryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SalesPostingInventoryCode")]
        public string SalesPostingInventoryCode { get; set; }

        /// <summary>
        /// Gets or Sets SalesPostingInventoryName
        /// </summary>
        [DataMember(Name = "SalesPostingInventoryName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SalesPostingInventoryName")]
        public string SalesPostingInventoryName { get; set; }

        /// <summary>
        /// Gets or Sets ServicePostingInventoryCode
        /// </summary>
        [DataMember(Name = "ServicePostingInventoryCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ServicePostingInventoryCode")]
        public string ServicePostingInventoryCode { get; set; }

        /// <summary>
        /// Gets or Sets ServicePostingInventoryName
        /// </summary>
        [DataMember(Name = "ServicePostingInventoryName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ServicePostingInventoryName")]
        public string ServicePostingInventoryName { get; set; }

        /// <summary>
        /// Gets or Sets IsAutoCreateGenericAccountInventory
        /// </summary>
        [DataMember(Name = "IsAutoCreateGenericAccountInventory", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsAutoCreateGenericAccountInventory")]
        public bool? IsAutoCreateGenericAccountInventory { get; set; }

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
        /// Gets or Sets CreatedWith
        /// </summary>
        [DataMember(Name = "CreatedWith", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CreatedWith")]
        public string CreatedWith { get; set; }

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
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets SalesPostingInventoryID
        /// </summary>
        [DataMember(Name = "SalesPostingInventoryID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SalesPostingInventoryID")]
        public int? SalesPostingInventoryID { get; set; }

        /// <summary>
        /// Gets or Sets ServicePostingInventoryID
        /// </summary>
        [DataMember(Name = "ServicePostingInventoryID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ServicePostingInventoryID")]
        public int? ServicePostingInventoryID { get; set; }

        /// <summary>
        /// Gets or Sets IsApprovedForWeb
        /// </summary>
        [DataMember(Name = "IsApprovedForWeb", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsApprovedForWeb")]
        public bool? IsApprovedForWeb { get; set; }

        /// <summary>
        /// Gets or Sets IsApprovedForService
        /// </summary>
        [DataMember(Name = "IsApprovedForService", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsApprovedForService")]
        public bool? IsApprovedForService { get; set; }

        /// <summary>
        /// Gets or Sets IsApprovedForPOS
        /// </summary>
        [DataMember(Name = "IsApprovedForPOS", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsApprovedForPOS")]
        public bool? IsApprovedForPOS { get; set; }

        /// <summary>
        /// Gets or Sets PostingBehaviour
        /// </summary>
        [DataMember(Name = "PostingBehaviour", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PostingBehaviour")]
        public string PostingBehaviour { get; set; }

        /// <summary>
        /// Gets or Sets InventoryClassGroup
        /// </summary>
        [DataMember(Name = "InventoryClassGroup", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "InventoryClassGroup")]
        public InventoryClassGroupT InventoryClassGroup { get; set; }

        /// <summary>
        /// Gets or Sets SyncLogs
        /// </summary>
        [DataMember(Name = "SyncLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SyncLogs")]
        public List<SyncLogT> SyncLogs { get; set; }

        /// <summary>
        /// Gets or Sets CountOfProducts
        /// </summary>
        [DataMember(Name = "CountOfProducts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CountOfProducts")]
        public int? CountOfProducts { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "IsSystem", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTimeUtc
        /// </summary>
        [DataMember(Name = "CreatedDateTime_utc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CreatedDateTime_utc")]
        public DateTime? CreatedDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedDateTimeUtc
        /// </summary>
        [DataMember(Name = "ModifiedDateTime_utc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ModifiedDateTime_utc")]
        public DateTime? ModifiedDateTimeUtc { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryClassT {\n");
            sb.Append("  GUID: ").Append(GUID).Append("\n");
            sb.Append("  SalesPostingInventoryCode: ").Append(SalesPostingInventoryCode).Append("\n");
            sb.Append("  SalesPostingInventoryName: ").Append(SalesPostingInventoryName).Append("\n");
            sb.Append("  ServicePostingInventoryCode: ").Append(ServicePostingInventoryCode).Append("\n");
            sb.Append("  ServicePostingInventoryName: ").Append(ServicePostingInventoryName).Append("\n");
            sb.Append("  IsAutoCreateGenericAccountInventory: ").Append(IsAutoCreateGenericAccountInventory).Append("\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  BSID: ").Append(BSID).Append("\n");
            sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  SalesPostingInventoryID: ").Append(SalesPostingInventoryID).Append("\n");
            sb.Append("  ServicePostingInventoryID: ").Append(ServicePostingInventoryID).Append("\n");
            sb.Append("  IsApprovedForWeb: ").Append(IsApprovedForWeb).Append("\n");
            sb.Append("  IsApprovedForService: ").Append(IsApprovedForService).Append("\n");
            sb.Append("  IsApprovedForPOS: ").Append(IsApprovedForPOS).Append("\n");
            sb.Append("  PostingBehaviour: ").Append(PostingBehaviour).Append("\n");
            sb.Append("  InventoryClassGroup: ").Append(InventoryClassGroup).Append("\n");
            sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
            sb.Append("  CountOfProducts: ").Append(CountOfProducts).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
            sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
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
