using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SDK.SpendaApi.Client.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CustomerBalance {
    /// <summary>
    /// Gets or Sets CustomerID
    /// </summary>
    [DataMember(Name="CustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerID")]
    public int? CustomerID { get; set; }

    /// <summary>
    /// Gets or Sets CustomerRefNumber
    /// </summary>
    [DataMember(Name="CustomerRefNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerRefNumber")]
    public string CustomerRefNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerName
    /// </summary>
    [DataMember(Name="CustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerName")]
    public string CustomerName { get; set; }

    /// <summary>
    /// Gets or Sets CustomerClassID
    /// </summary>
    [DataMember(Name="CustomerClassID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerClassID")]
    public int? CustomerClassID { get; set; }

    /// <summary>
    /// Gets or Sets CustomerClassName
    /// </summary>
    [DataMember(Name="CustomerClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomerClassName")]
    public string CustomerClassName { get; set; }

    /// <summary>
    /// Gets or Sets IsAccountCustomer
    /// </summary>
    [DataMember(Name="IsAccountCustomer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAccountCustomer")]
    public bool? IsAccountCustomer { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerID
    /// </summary>
    [DataMember(Name="AccountCustomerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerID")]
    public int? AccountCustomerID { get; set; }

    /// <summary>
    /// Gets or Sets AccountCustomerName
    /// </summary>
    [DataMember(Name="AccountCustomerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCustomerName")]
    public string AccountCustomerName { get; set; }

    /// <summary>
    /// Gets or Sets TransCount
    /// </summary>
    [DataMember(Name="TransCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransCount")]
    public int? TransCount { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="Balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// Gets or Sets OldestTransDate
    /// </summary>
    [DataMember(Name="OldestTransDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldestTransDate")]
    public DateTime? OldestTransDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerBalance {\n");
      sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
      sb.Append("  CustomerRefNumber: ").Append(CustomerRefNumber).Append("\n");
      sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
      sb.Append("  CustomerClassID: ").Append(CustomerClassID).Append("\n");
      sb.Append("  CustomerClassName: ").Append(CustomerClassName).Append("\n");
      sb.Append("  IsAccountCustomer: ").Append(IsAccountCustomer).Append("\n");
      sb.Append("  AccountCustomerID: ").Append(AccountCustomerID).Append("\n");
      sb.Append("  AccountCustomerName: ").Append(AccountCustomerName).Append("\n");
      sb.Append("  TransCount: ").Append(TransCount).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  OldestTransDate: ").Append(OldestTransDate).Append("\n");
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
