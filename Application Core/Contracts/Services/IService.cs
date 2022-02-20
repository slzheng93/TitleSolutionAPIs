using Application_Core.Entities;
using Application_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Contracts.Services
{
    public interface IService
    {
        Task<List<Title>> GetAllTitle();
        Task<List<Title>> SearchTitleByName(string name);
        Task<TitleDetailsResponseModel> GetTitleDetail(int titleId);
    }
}
