using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using Spenda.SDK.Models;
using System.Diagnostics;

namespace Spenda.SDK.Tests
{
    [TestClass()]
    public class InventoryTests : BaseTests
    {
        [TestMethod()]
        public void InventoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllInventoryTest()
        {
            var request = new RestRequest("/api/Inventory");
            request.AddParameter("filter.maxResults", 10);

            var obj = Get<PagedActionResultsOfInventoryItems>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            foreach (var inventory in obj.Value)
            {
                Trace.WriteLine($"Inventory Id: {inventory.ID}, Inventory Short Description: {inventory.ShortDescription}");
            }
        }

        [TestMethod()]
        public void GetnventoryByIdTest()
        {
            var url = $"/api/Inventory/{1057343}";
            var request = new RestRequest(url);

            var obj = Get<InventoryEditResponse>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Inventory Id: {obj.Value.ID}, Inventory Short Description: {obj.Value.ShortDescription}");
        }

        [TestMethod()]
        public void CreateInventoryTest()
        {
            var body = JsonConvert.SerializeObject(Mocks.Inventory.getInventoryObject());

            var request = new RestRequest("/api/Inventory");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var obj = Post<SynkSaveQueueResponse>(request);

            AssertSuccess(obj.Messages, obj.IsSuccess);
            Trace.WriteLine($"Inventory Id: {obj.Value.ID}, Inventory RefNumber: {obj.Value.RefNumber}");
        }
    }
}
