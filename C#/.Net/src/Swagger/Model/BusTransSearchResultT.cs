using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BusTransSearchResultT {
    /// <summary>
    /// Gets or Sets TotalQuantity
    /// </summary>
    [DataMember(Name="TotalQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalQuantity")]
    public double? TotalQuantity { get; set; }

    /// <summary>
    /// Gets or Sets OtherPartyInvoiceRefNumber
    /// </summary>
    [DataMember(Name="OtherPartyInvoiceRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherPartyInvoiceRefNumber")]
    public string OtherPartyInvoiceRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets IsChargeToAccount
    /// </summary>
    [DataMember(Name="IsChargeToAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsChargeToAccount")]
    public bool? IsChargeToAccount { get; set; }

    /// <summary>
    /// Gets or Sets RowNumber
    /// </summary>
    [DataMember(Name="RowNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RowNumber")]
    public long? RowNumber { get; set; }

    /// <summary>
    /// Gets or Sets ID
    /// </summary>
    [DataMember(Name="ID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ID")]
    public int? ID { get; set; }

    /// <summary>
    /// Gets or Sets RefNumber
    /// </summary>
    [DataMember(Name="RefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefNumber")]
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or Sets RefTransRefNumber
    /// </summary>
    [DataMember(Name="RefTransRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RefTransRefNumber")]
    public string RefTransRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerRefTransRefNumber
    /// </summary>
    [DataMember(Name="CustomerRefTransRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerRefTransRefNumber")]
    public string CustomerRefTransRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets OtherPartyID
    /// </summary>
    [DataMember(Name="OtherPartyID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherPartyID")]
    public int? OtherPartyID { get; set; }

    /// <summary>
    /// Gets or Sets OtherPartyName
    /// </summary>
    [DataMember(Name="OtherPartyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherPartyName")]
    public string OtherPartyName { get; set; }

    /// <summary>
    /// Gets or Sets IsLinkedToOtherParty
    /// </summary>
    [DataMember(Name="IsLinkedToOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLinkedToOtherParty")]
    public bool? IsLinkedToOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets IsCreatedByOtherParty
    /// </summary>
    [DataMember(Name="IsCreatedByOtherParty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCreatedByOtherParty")]
    public bool? IsCreatedByOtherParty { get; set; }

    /// <summary>
    /// Gets or Sets CreatedByUserName
    /// </summary>
    [DataMember(Name="CreatedByUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserName")]
    public string CreatedByUserName { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedByUserName
    /// </summary>
    [DataMember(Name="ModifiedByUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedByUserName")]
    public string ModifiedByUserName { get; set; }

    /// <summary>
    /// Gets or Sets TransDate
    /// </summary>
    [DataMember(Name="TransDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDate")]
    public DateTime? TransDate { get; set; }

    /// <summary>
    /// Gets or Sets DueDate
    /// </summary>
    [DataMember(Name="DueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTimeUtc
    /// </summary>
    [DataMember(Name="CreatedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDateTime_utc")]
    public DateTime? CreatedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedDateTimeUtc
    /// </summary>
    [DataMember(Name="ModifiedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModifiedDateTime_utc")]
    public DateTime? ModifiedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets AcceptedDateTimeUtc
    /// </summary>
    [DataMember(Name="AcceptedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcceptedDateTime_utc")]
    public DateTime? AcceptedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets SentDateTimeUtc
    /// </summary>
    [DataMember(Name="SentDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SentDateTime_utc")]
    public DateTime? SentDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets FinalisedDateTimeUtc
    /// </summary>
    [DataMember(Name="FinalisedDateTime_utc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FinalisedDateTime_utc")]
    public DateTime? FinalisedDateTimeUtc { get; set; }

    /// <summary>
    /// Gets or Sets TotalEx
    /// </summary>
    [DataMember(Name="TotalEx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalEx")]
    public double? TotalEx { get; set; }

    /// <summary>
    /// Gets or Sets TotalInc
    /// </summary>
    [DataMember(Name="TotalInc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalInc")]
    public double? TotalInc { get; set; }

    /// <summary>
    /// Gets or Sets TotalTax
    /// </summary>
    [DataMember(Name="TotalTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTax")]
    public double? TotalTax { get; set; }

    /// <summary>
    /// Gets or Sets LineCount
    /// </summary>
    [DataMember(Name="LineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LineCount")]
    public int? LineCount { get; set; }

    /// <summary>
    /// Gets or Sets LinesWithUnmappedInventoryCount
    /// </summary>
    [DataMember(Name="LinesWithUnmappedInventoryCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinesWithUnmappedInventoryCount")]
    public int? LinesWithUnmappedInventoryCount { get; set; }

    /// <summary>
    /// Gets or Sets WasSentWhenLinked
    /// </summary>
    [DataMember(Name="WasSentWhenLinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasSentWhenLinked")]
    public bool? WasSentWhenLinked { get; set; }

    /// <summary>
    /// Gets or Sets WasSentWhenUnlinked
    /// </summary>
    [DataMember(Name="WasSentWhenUnlinked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasSentWhenUnlinked")]
    public bool? WasSentWhenUnlinked { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BusTransSearchResultT {\n");
      sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
      sb.Append("  OtherPartyInvoiceRefNumber: ").Append(OtherPartyInvoiceRefNumber).Append("\n");
      sb.Append("  IsChargeToAccount: ").Append(IsChargeToAccount).Append("\n");
      sb.Append("  RowNumber: ").Append(RowNumber).Append("\n");
      sb.Append("  ID: ").Append(ID).Append("\n");
      sb.Append("  RefNumber: ").Append(RefNumber).Append("\n");
      sb.Append("  RefTransRefNumber: ").Append(RefTransRefNumber).Append("\n");
      sb.Append("  CustomerRefTransRefNumber: ").Append(CustomerRefTransRefNumber).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  OtherPartyID: ").Append(OtherPartyID).Append("\n");
      sb.Append("  OtherPartyName: ").Append(OtherPartyName).Append("\n");
      sb.Append("  IsLinkedToOtherParty: ").Append(IsLinkedToOtherParty).Append("\n");
      sb.Append("  IsCreatedByOtherParty: ").Append(IsCreatedByOtherParty).Append("\n");
      sb.Append("  CreatedByUserName: ").Append(CreatedByUserName).Append("\n");
      sb.Append("  ModifiedByUserName: ").Append(ModifiedByUserName).Append("\n");
      sb.Append("  TransDate: ").Append(TransDate).Append("\n");
      sb.Append("  DueDate: ").Append(DueDate).Append("\n");
      sb.Append("  CreatedDateTimeUtc: ").Append(CreatedDateTimeUtc).Append("\n");
      sb.Append("  ModifiedDateTimeUtc: ").Append(ModifiedDateTimeUtc).Append("\n");
      sb.Append("  AcceptedDateTimeUtc: ").Append(AcceptedDateTimeUtc).Append("\n");
      sb.Append("  SentDateTimeUtc: ").Append(SentDateTimeUtc).Append("\n");
      sb.Append("  FinalisedDateTimeUtc: ").Append(FinalisedDateTimeUtc).Append("\n");
      sb.Append("  TotalEx: ").Append(TotalEx).Append("\n");
      sb.Append("  TotalInc: ").Append(TotalInc).Append("\n");
      sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
      sb.Append("  LineCount: ").Append(LineCount).Append("\n");
      sb.Append("  LinesWithUnmappedInventoryCount: ").Append(LinesWithUnmappedInventoryCount).Append("\n");
      sb.Append("  WasSentWhenLinked: ").Append(WasSentWhenLinked).Append("\n");
      sb.Append("  WasSentWhenUnlinked: ").Append(WasSentWhenUnlinked).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
