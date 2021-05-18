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
    public class CategoryTests : BaseTests
    {
        public List<CategoryT> SearchCategories(string searchString = null,
                                              int maxNoOfRecords = 10,
                                              bool isExactMatch = false)
        {
            var request = new RestRequest("/api/Category");

            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.searchString", searchString); // For this example we're assuming the search string is the Business Name
            request.AddParameter("filter.isExactMatch", isExactMatch);

            request.AddParameter("filter.sortField", "ShortDescription"); // Options include : RefNumber, Phone1, ABN, CreatedDateTime, and ModifiedDateTime

            var response = Get<PagedActionResultsOfCategories>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetAllInventory_Test()
        {
            var categories = SearchCategories();

            //loop through to display the records
            foreach (var category in categories)
            {
                Trace.WriteLine($"Category Id: {category.ID}, Category Description: {category.Description}");
            }
        }
    }
}
