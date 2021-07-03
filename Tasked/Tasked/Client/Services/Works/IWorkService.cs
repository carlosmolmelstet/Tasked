using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasked.Shared.Data;

namespace Tasked.Client.Services.Works
{
    public interface IWorkService
    {
        Task<List<Work>> GetWorks();
    }
}
