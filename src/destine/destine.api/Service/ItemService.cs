using System;
using System.Collections.Generic;
using System.Text;
using Destine.Client.Http;
using System.Threading.Tasks;
using Destine.Api.Models;
using Flurl.Http;
using System.Collections.Generic;
using Destine.Api.Utilities;
using System.Linq;

namespace Destine.Api.Service
{
    public class ItemService
    {
        private const int aggregateCount = 10;
        private readonly DestineHttpClient client;

        public ItemService()
        {
            client = new DestineHttpClient();
        }

        public async Task<Item> GetItemById(string id)
        {
            return await client.Request()
                .AppendPathSegments("item", id)
                .AppendPathSegment(string.Join("", new string[] { Constants.Json, Constants.PrintPretty }))
                .GetJsonAsync<Item>();
        }

        public async Task<List<Item>> GetAggregate(string aggregateType)
        {
            List<Item> items = new List<Item>();
            var request = client.Request()
                .AppendPathSegment(string.Join("", new string[] { aggregateType, Constants.Json }));

            var result = await request
                .GetJsonAsync<string[]>();

            var topResults = (from r in result
                              select r).Take(aggregateCount);

            foreach(var id in topResults)
            {
                items.Add(await GetItemById(id));
            }

            return items;
        }

    }
}
