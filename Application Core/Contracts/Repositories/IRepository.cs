using Application_Core.Entities;
using Application_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Contracts.Repositories
{
    public interface IRepository
    {
        Task<List<Title>> GetAllTitle();
        Task<List<Title>> SearchTitleByName(string Name);
        Task<Title> GetById(int id);
        
    }
}
// IEnumerable is read-only and List is not