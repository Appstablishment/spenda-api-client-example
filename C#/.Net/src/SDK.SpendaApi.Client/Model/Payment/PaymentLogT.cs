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
    public class PaymentLogT
    {
        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "Code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets LogDateTimeUtc
        /// </summary>
        [DataMember(Name = "LogDateTime_utc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "LogDateTime_utc")]
        public DateTime? LogDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets LogDateTimeOffset
        /// </summary>
        [DataMember(Name = "LogDateTime_offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "LogDateTime_offset")]
        public int? LogDateTimeOffset { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLogT {\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LogDateTimeUtc: ").Append(LogDateTimeUtc).Append("\n");
            sb.Append("  LogDateTimeOffset: ").Append(LogDateTimeOffset).Append("\n");
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
