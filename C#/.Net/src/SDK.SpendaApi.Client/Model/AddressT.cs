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
    public class AddressT
    {
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Gets or Sets GUID
        /// </summary>
        [DataMember(Name = "GUID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUID")]
        public Guid? GUID { get; set; }

        /// <summary>
        /// Gets or Sets FullAddress
        /// </summary>
        [DataMember(Name = "FullAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "FullAddress")]
        public string FullAddress { get; set; }

        /// <summary>
        /// Gets or Sets IsDeliverTo
        /// </summary>
        [DataMember(Name = "IsDeliverTo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsDeliverTo")]
        public bool? IsDeliverTo { get; set; }

        /// <summary>
        /// Gets or Sets IsMailTo
        /// </summary>
        [DataMember(Name = "IsMailTo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsMailTo")]
        public bool? IsMailTo { get; set; }

        /// <summary>
        /// Gets or Sets IsOfficeOrShop
        /// </summary>
        [DataMember(Name = "IsOfficeOrShop", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsOfficeOrShop")]
        public bool? IsOfficeOrShop { get; set; }

        /// <summary>
        /// Gets or Sets IsPostalAddress
        /// </summary>
        [DataMember(Name = "IsPostalAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsPostalAddress")]
        public bool? IsPostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets IsSelectedBilling
        /// </summary>
        [DataMember(Name = "IsSelectedBilling", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSelectedBilling")]
        public bool? IsSelectedBilling { get; set; }

        /// <summary>
        /// Gets or Sets IsSelectedDelivery
        /// </summary>
        [DataMember(Name = "IsSelectedDelivery", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSelectedDelivery")]
        public bool? IsSelectedDelivery { get; set; }

        /// <summary>
        /// Gets or Sets IsServiceTo
        /// </summary>
        [DataMember(Name = "IsServiceTo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsServiceTo")]
        public bool? IsServiceTo { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "Latitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "Longitude", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name = "LocationID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "LocationID")]
        public int? LocationID { get; set; }

        /// <summary>
        /// Gets or Sets IsSystem
        /// </summary>
        [DataMember(Name = "IsSystem", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or Sets GUIDstring
        /// </summary>
        [DataMember(Name = "GUIDstring", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "GUIDstring")]
        public string GUIDstring { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name = "AddressType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AddressType")]
        public int? AddressType { get; set; }

        /// <summary>
        /// Gets or Sets AddressDescription
        /// </summary>
        [DataMember(Name = "AddressDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "AddressDescription")]
        public string AddressDescription { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "StreetAddress", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "StreetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name = "PostCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "PostCode")]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultDeliverTo
        /// </summary>
        [DataMember(Name = "IsDefaultDeliverTo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsDefaultDeliverTo")]
        public bool? IsDefaultDeliverTo { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultBilling
        /// </summary>
        [DataMember(Name = "IsDefaultBilling", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsDefaultBilling")]
        public bool? IsDefaultBilling { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultServiceTo
        /// </summary>
        [DataMember(Name = "IsDefaultServiceTo", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsDefaultServiceTo")]
        public bool? IsDefaultServiceTo { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "Notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Notes")]
        public string Notes { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressT {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  GUID: ").Append(GUID).Append("\n");
            sb.Append("  FullAddress: ").Append(FullAddress).Append("\n");
            sb.Append("  IsDeliverTo: ").Append(IsDeliverTo).Append("\n");
            sb.Append("  IsMailTo: ").Append(IsMailTo).Append("\n");
            sb.Append("  IsOfficeOrShop: ").Append(IsOfficeOrShop).Append("\n");
            sb.Append("  IsPostalAddress: ").Append(IsPostalAddress).Append("\n");
            sb.Append("  IsSelectedBilling: ").Append(IsSelectedBilling).Append("\n");
            sb.Append("  IsSelectedDelivery: ").Append(IsSelectedDelivery).Append("\n");
            sb.Append("  IsServiceTo: ").Append(IsServiceTo).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  GUIDstring: ").Append(GUIDstring).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  AddressDescription: ").Append(AddressDescription).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  IsDefaultDeliverTo: ").Append(IsDefaultDeliverTo).Append("\n");
            sb.Append("  IsDefaultBilling: ").Append(IsDefaultBilling).Append("\n");
            sb.Append("  IsDefaultServiceTo: ").Append(IsDefaultServiceTo).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
