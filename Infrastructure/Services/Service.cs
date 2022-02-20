using Application_Core.Contracts.Repositories;
using Application_Core.Contracts.Services;
using Application_Core.Entities;
using Application_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        //constructor injection
        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Title>> GetAllTitle()
        {
            return await _repository.GetAllTitle();
        }

        public async Task<TitleDetailsResponseModel> GetTitleDetail(int titleId)
        {
            var titleDetails = await _repository.GetById(titleId);

            // Adding general info about the Title
            var titleModel = new TitleDetailsResponseModel
            {
                TitleId = titleDetails.TitleId,
                TitleName = titleDetails.TitleName,
                TitleNameSortable = titleDetails.TitleNameSortable,
                TitleTypeId = titleDetails.TitleTypeId,
                ReleaseYear = titleDetails.ReleaseYear,
                ProcessedDateTimeUTC = titleDetails.ProcessedDateTimeUTC,
            };

            // Adding award info
            foreach(var award in titleDetails.Award)
            {
                titleModel.Award.Add(new Awards
                {
                    TitleId = award.TitleId,
                    AwardWon = award.AwardWon,
                    AwardYear = award.AwardYear,
                    AwardCompany = award.AwardCompany,
                    Id = award.Id,
                });
            }

            // Adding otherNames info
            foreach(var otherNames in titleDetails.OtherNames)
            {
                titleModel.OtherNames.Add(new OtherName
                {
                    TitleNameLanguage = otherNames.TitleNameLanguage,
                    TitleNameType = otherNames.TitleNameType,
                    TitleNameSortable = otherNames.TitleNameSortable,
                    TitleName = otherNames.TitleName,
                });
            }

            // Adding storylines
            foreach(var storyLine in titleDetails.StoryLines)
            {
                titleModel.StoryLines.Add(new StoryLine
                {
                    Type = storyLine.Type,
                    Language = storyLine.Language,
                    Description = storyLine.Description,
                });
            }

            // Adding participant
            foreach(var participant in titleDetails.TitleParticipants)
            {
                titleModel.Participant.Add(new Participant
                {
                    Name = participant.Participant.Name,
                    ParticipantType = participant.Participant.ParticipantType,
                });
            }

            // Adding title participant
            foreach(var titleParticipant in titleDetails.TitleParticipants)
            {
                titleModel.TitleParticipant.Add(new Titleparticipant
                {
                    RoleType = titleParticipant.RoleType,
                    IsKey = titleParticipant.IsKey,
                    IsOnScreen = titleParticipant.IsOnScreen,
                    ParticipantId = titleParticipant.ParticipantId,
                });
            }

            // Adding genre info
            foreach(var titleGenre in titleDetails.TitleGenres)
            {
                titleModel.Genre.Add(new Genre
                {
                    Name = titleGenre.Genre.Name,
                    Id = titleGenre.Genre.Id,
                });
            }

            return titleModel;
        }

        public async Task<List<Title>> SearchTitleByName(string Name)
        {
            return await _repository.SearchTitleByName(Name);
        }
    }
}
