using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleHealthApplication
{
    class ClientBody
    {
        [Required]
        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("middleName")]
        public string middleName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonProperty("address")]
        public string address { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("province")]
        public string province { get; set; }

        [JsonProperty("postalCode")]
        public string postalCode { get; set; }

        [JsonProperty("concerns")]
        public string concerns { get; set; }

        [JsonProperty("response")]
        public string response { get; set; }
    }
}
