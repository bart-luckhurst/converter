using Convert.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Convert.Core.Repositories
{
    public interface IUnitRepository
    {
        Task<List<Unit>> GetUnitsAsync();
    }
}
