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
    public class TagT
    {
        /// <summary>
        /// Gets or Sets SyncLogs
        /// </summary>
        [DataMember(Name = "SyncLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SyncLogs")]
        public List<SyncLogT> SyncLogs { get; set; }

        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        [DataMember(Name = "GUID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUID")]
        public Guid? GUID { get; set; }

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
        /// Gets or Sets URL
        /// </summary>
        [DataMember(Name = "URL", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "URL")]
        public string URL { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "Slug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagT {\n");
            sb.Append("  SyncLogs: ").Append(SyncLogs).Append("\n");
            sb.Append("  GUID: ").Append(GUID).Append("\n");
            sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  BSID: ").Append(BSID).Append("\n");
            sb.Append("  CreatedWith: ").Append(CreatedWith).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
