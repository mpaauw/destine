using Destine.Client.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Destine.Client.Actions
{
    public class ClientActions : IClientActions
    {
        private readonly DestineHttpClient client;

        public ClientActions()
        {
            client = new DestineHttpClient();
        }

        public async Task<string> Help()
        {
            return "Here is a list of all commands available: foobar";
        }
    }
}
