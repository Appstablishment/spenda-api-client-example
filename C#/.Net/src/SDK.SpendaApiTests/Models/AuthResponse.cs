using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.SpendaApiTests.Models
{
    public class AuthResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string expires { get; set; }
        public string issued { get; set; }
        public string DefaultSupplierMarketplace { get; set; }
        public string FirstName { get; set; }
        public string Is2SAEnabled { get; set; }
        public string Is2SASetupRequired { get; set; }
        public string Is2SAuthenticated { get; set; }
        public string IsAdministrator { get; set; }
        public string IsNewTenant { get; set; }
        public string IsSupport { get; set; }
        public string IsTempPassword { get; set; }
        public string LastName { get; set; }
        public string Modules { get; set; }
        public string OptionsFor2SA { get; set; }
        public string TenantGlobalCode { get; set; }
        public string TenantID { get; set; }
        public string TenantName { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string WebsiteID { get; set; }
    }

}
