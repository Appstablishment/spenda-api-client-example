using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Spenda.SDK.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class BrandTests : BaseTests
    {
        public List<BrandT> SearchBrands(string searchString = null,
                                      int maxNoOfRecords = 10,
                                      bool isExactMatch = false)
        {
            var request = new RestRequest("/api/Brand");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.searchString", searchString); // For this example we're assuming the search string is the Business Name
            request.AddParameter("filter.isExactMatch", isExactMatch);

            request.AddParameter("filter.sortField", "ShortDescription"); // Options include : RefNumber, Phone1, ABN, CreatedDateTime, and ModifiedDateTime

            var response = Get<PagedActionResultsOfBrands>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetAllBrand_Test()
        {
            var brands = SearchBrands();

            //loop through to display the records
            foreach (var brand in brands)
            {
                Trace.WriteLine($"Brand Id: {brand.ID}, Brand Name: {brand.Name}");
            }
        }
    }
}
