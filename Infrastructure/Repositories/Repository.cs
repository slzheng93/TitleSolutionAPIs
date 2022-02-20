using Application_Core.Contracts.Repositories;
using Application_Core.Entities;
using Application_Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Repository : IRepository
    {
        // Connection to database (_dbContext)
        private readonly TitlesDbContext _dbContext;
        public Repository(TitlesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Title>> GetAllTitle()
        {
            return await _dbContext.Title.ToListAsync();
        }

        public async Task<Title> GetById(int titleId)
        {
            var title = await _dbContext.Title.Include(t => t.Award)
                                              .Include(t => t.OtherNames)
                                              .Include(t => t.StoryLines)
                                              .Include(t => t.TitleParticipants)
                                              .ThenInclude(t => t.Participant)
                                              .Include(t => t.TitleGenres)
                                              .ThenInclude(t => t.Genre)
                                              .FirstOrDefaultAsync(t => t.TitleId == titleId);
            return title;
        }

        public async Task<List<Title>> SearchTitleByName(string name)
        {
            var searchResult = await _dbContext.Title.Where(t => t.TitleName.Contains(name)).ToListAsync();

            return searchResult;
        }
    }
}
