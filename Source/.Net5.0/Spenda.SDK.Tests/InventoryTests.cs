using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class InventoryTests : BaseTests
    {
        public List<InventoryItemT> SearchInventories(string searchString = null,
                                                      int maxNoOfRecords = 10,
                                                      bool isExactMatch = false)
        {
            var request = new RestRequest("/api/Inventory");
            
            //Required parameters
            request.AddParameter("filter.maxResults", maxNoOfRecords);

            //Optional parameters
            request.AddParameter("filter.searchString", searchString); // For this example we're assuming the search string is the Business Name
            request.AddParameter("filter.isExactMatch", isExactMatch);

            request.AddParameter("filter.sortField", "ShortDescription"); // Options include : RefNumber, Phone1, ABN, CreatedDateTime, and ModifiedDateTime

            var response = Get<PagedActionResultsOfInventoryItems>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            return response.Value;
        }

        [TestMethod()]
        public void GetAllInventory_Test()
        {
            var inventories = SearchInventories();

            //loop through to display the records
            foreach (var inventory in inventories)
            {
                Trace.WriteLine($"Inventory Id: {inventory.ID}, Inventory Short Description: {inventory.ShortDescription}");
            }
        }

        public InventoryItemT GetnventoryByID(int id)
        {
            var request = new RestRequest($"/api/Inventory/{id}");

            var response = Get<InventoryEditResponse>(request);

            AssertSuccess(response.Messages, response.IsSuccess);

            InventoryItemT inventory = response.Value;

            Assert.IsNotNull(inventory);

            Trace.WriteLine($"Inventory Id: {inventory.ID}, Inventory Short Description: {inventory.ShortDescription}");

            return inventory;
        }

        [TestMethod()]
        public void GetnventoryByID_Test()
        {
            // Get all customers first just so that we can get a valid ID
            var inventories = SearchInventories();

            if (!(inventories?.Any() ?? false)) Assert.Fail("Not Inventories found");

            //select the top inventory ID
            var inventoryID = inventories.FirstOrDefault()?.ID;

            Assert.IsNotNull(inventoryID);

            // Get the Inventory by ID
            var inventory = GetnventoryByID(78);

            Assert.IsNotNull(inventory);
        }

        [TestMethod()]
        public void CreateInventory_Test()
        {
            var newInventory = Mocks.Inventory.GetInventoryWithCreatedCategories();

            var searchString = newInventory.Object.ShortDescription;

            Assert.IsNotNull(searchString);

            // Search for existing inventory record
            var inventories = SearchInventories(searchString: searchString, 10, isExactMatch: true);

            if (inventories?.Any() ?? false)
            {
                Assert.Fail($"Inventory {searchString} already found");
                // Update ?
            }
            else
            {
                var body = JsonConvert.SerializeObject(newInventory);

                var request = new RestRequest("/api/Inventory");
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                var obj = Post<SynkSaveQueueResponse>(request);

                AssertSuccess(obj.Messages, obj.IsSuccess);
                Trace.WriteLine($"Inventory Id: {obj.Value.ID}, Inventory RefNumber: {obj.Value.RefNumber}");
            }
        }
    }
}
