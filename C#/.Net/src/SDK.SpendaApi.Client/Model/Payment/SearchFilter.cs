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
    public class SearchFilter
    {
        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name = "Statuses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Statuses")]
        public List<int?> Statuses { get; set; }

        /// <summary>
        /// Gets or Sets StatusStrings
        /// </summary>
        [DataMember(Name = "StatusStrings", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "StatusStrings")]
        public List<string> StatusStrings { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// Gets or Sets SearchString
        /// </summary>
        [DataMember(Name = "SearchString", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SearchString")]
        public string SearchString { get; set; }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "Search", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Search")]
        public string Search { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "StartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "StartDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "EndDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "EndDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets DatePeriod
        /// </summary>
        [DataMember(Name = "DatePeriod", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "DatePeriod")]
        public string DatePeriod { get; set; }

        /// <summary>
        /// Gets or Sets IsExactMatch
        /// </summary>
        [DataMember(Name = "IsExactMatch", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsExactMatch")]
        public bool? IsExactMatch { get; set; }

        /// <summary>
        /// Gets or Sets IsGetBasicInfo
        /// </summary>
        [DataMember(Name = "IsGetBasicInfo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsGetBasicInfo")]
        public bool? IsGetBasicInfo { get; set; }

        /// <summary>
        /// Gets or Sets IncludeDeleted
        /// </summary>
        [DataMember(Name = "IncludeDeleted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IncludeDeleted")]
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// Gets or Sets IncludeLogs
        /// </summary>
        [DataMember(Name = "IncludeLogs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IncludeLogs")]
        public bool? IncludeLogs { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreID
        /// </summary>
        [DataMember(Name = "IgnoreID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IgnoreID")]
        public int? IgnoreID { get; set; }

        /// <summary>
        /// Gets or Sets ParentID
        /// </summary>
        [DataMember(Name = "ParentID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ParentID")]
        public int? ParentID { get; set; }

        /// <summary>
        /// Gets or Sets GetCountOnly
        /// </summary>
        [DataMember(Name = "GetCountOnly", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GetCountOnly")]
        public bool? GetCountOnly { get; set; }

        /// <summary>
        /// Gets or Sets TransactionTypeDatTypeID
        /// </summary>
        [DataMember(Name = "TransactionTypeDatTypeID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TransactionTypeDatTypeID")]
        public int? TransactionTypeDatTypeID { get; set; }

        /// <summary>
        /// Gets or Sets CategoryID
        /// </summary>
        [DataMember(Name = "CategoryID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CategoryID")]
        public int? CategoryID { get; set; }

        /// <summary>
        /// Gets or Sets AdaptorID
        /// </summary>
        [DataMember(Name = "AdaptorID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AdaptorID")]
        public int? AdaptorID { get; set; }

        /// <summary>
        /// Gets or Sets CategoryIDs
        /// </summary>
        [DataMember(Name = "CategoryIDs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "CategoryIDs")]
        public List<int?> CategoryIDs { get; set; }

        /// <summary>
        /// Gets or Sets BrandIDs
        /// </summary>
        [DataMember(Name = "BrandIDs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "BrandIDs")]
        public List<int?> BrandIDs { get; set; }

        /// <summary>
        /// Gets or Sets IDs
        /// </summary>
        [DataMember(Name = "IDs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IDs")]
        public List<int?> IDs { get; set; }

        /// <summary>
        /// Gets or Sets GUIDs
        /// </summary>
        [DataMember(Name = "GUIDs", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUIDs")]
        public List<string> GUIDs { get; set; }

        /// <summary>
        /// Gets or Sets LinkedSupplierID
        /// </summary>
        [DataMember(Name = "LinkedSupplierID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "LinkedSupplierID")]
        public int? LinkedSupplierID { get; set; }

        /// <summary>
        /// Gets or Sets IsApprovedForPOS
        /// </summary>
        [DataMember(Name = "IsApprovedForPOS", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsApprovedForPOS")]
        public bool? IsApprovedForPOS { get; set; }

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
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Gets or Sets IsHierarchicalSort
        /// </summary>
        [DataMember(Name = "IsHierarchicalSort", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsHierarchicalSort")]
        public bool? IsHierarchicalSort { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "Types", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Types")]
        public List<string> Types { get; set; }

        /// <summary>
        /// Gets or Sets IsShowFavourites
        /// </summary>
        [DataMember(Name = "IsShowFavourites", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsShowFavourites")]
        public bool? IsShowFavourites { get; set; }

        /// <summary>
        /// Gets or Sets IsHidden
        /// </summary>
        [DataMember(Name = "IsHidden", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsHidden")]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSystemTasks
        /// </summary>
        [DataMember(Name = "IncludeSystemTasks", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IncludeSystemTasks")]
        public bool? IncludeSystemTasks { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "IsSystem", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or Sets SortField
        /// </summary>
        [DataMember(Name = "SortField", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SortField")]
        public string SortField { get; set; }

        /// <summary>
        /// Gets or Sets SortAsc
        /// </summary>
        [DataMember(Name = "SortAsc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "SortAsc")]
        public bool? SortAsc { get; set; }

        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name = "GroupBy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GroupBy")]
        public string GroupBy { get; set; }

        /// <summary>
        /// Gets or Sets LastRowNumber
        /// </summary>
        [DataMember(Name = "LastRowNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "LastRowNumber")]
        public long? LastRowNumber { get; set; }

        /// <summary>
        /// Gets or Sets MaxResults
        /// </summary>
        [DataMember(Name = "MaxResults", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "MaxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Gets or Sets TenantID
        /// </summary>
        [DataMember(Name = "TenantID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "TenantID")]
        public int? TenantID { get; set; }

        /// <summary>
        /// Gets or Sets WebsiteID
        /// </summary>
        [DataMember(Name = "WebsiteID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "WebsiteID")]
        public int? WebsiteID { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name = "UserID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "UserID")]
        public int? UserID { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchFilter {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  StatusStrings: ").Append(StatusStrings).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  DatePeriod: ").Append(DatePeriod).Append("\n");
            sb.Append("  IsExactMatch: ").Append(IsExactMatch).Append("\n");
            sb.Append("  IsGetBasicInfo: ").Append(IsGetBasicInfo).Append("\n");
            sb.Append("  IncludeDeleted: ").Append(IncludeDeleted).Append("\n");
            sb.Append("  IncludeLogs: ").Append(IncludeLogs).Append("\n");
            sb.Append("  IgnoreID: ").Append(IgnoreID).Append("\n");
            sb.Append("  ParentID: ").Append(ParentID).Append("\n");
            sb.Append("  GetCountOnly: ").Append(GetCountOnly).Append("\n");
            sb.Append("  TransactionTypeDatTypeID: ").Append(TransactionTypeDatTypeID).Append("\n");
            sb.Append("  CategoryID: ").Append(CategoryID).Append("\n");
            sb.Append("  AdaptorID: ").Append(AdaptorID).Append("\n");
            sb.Append("  CategoryIDs: ").Append(CategoryIDs).Append("\n");
            sb.Append("  BrandIDs: ").Append(BrandIDs).Append("\n");
            sb.Append("  IDs: ").Append(IDs).Append("\n");
            sb.Append("  GUIDs: ").Append(GUIDs).Append("\n");
            sb.Append("  LinkedSupplierID: ").Append(LinkedSupplierID).Append("\n");
            sb.Append("  IsApprovedForPOS: ").Append(IsApprovedForPOS).Append("\n");
            sb.Append("  IsApprovedForWeb: ").Append(IsApprovedForWeb).Append("\n");
            sb.Append("  IsApprovedForService: ").Append(IsApprovedForService).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  IsHierarchicalSort: ").Append(IsHierarchicalSort).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  IsShowFavourites: ").Append(IsShowFavourites).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  IncludeSystemTasks: ").Append(IncludeSystemTasks).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  SortField: ").Append(SortField).Append("\n");
            sb.Append("  SortAsc: ").Append(SortAsc).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  LastRowNumber: ").Append(LastRowNumber).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  TenantID: ").Append(TenantID).Append("\n");
            sb.Append("  WebsiteID: ").Append(WebsiteID).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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
