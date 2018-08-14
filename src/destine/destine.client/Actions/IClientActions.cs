using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Destine.Client.Actions
{
    public interface IClientActions
    {
        Task<string> Help();
    }
}
