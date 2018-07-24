using Destine.Api.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Destine.Api.Utilities;

namespace Destine.Console
{

    public static class Display
    {
        public static void Test()
        {
            ItemService service = new ItemService();
            var hmmm = service.GetAggregate(Aggregates.TopStories).Result;
        }
    }
}
