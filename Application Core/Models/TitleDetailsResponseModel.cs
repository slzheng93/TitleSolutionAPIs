using Application_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Models
{

    // Model to store the details data
    public class TitleDetailsResponseModel
    {
        // Initialize the list property
        public TitleDetailsResponseModel()
        {
            Award = new List<Awards>();
            OtherNames = new List<OtherName>();
            StoryLines = new List<StoryLine>();
            Participant = new List<Participant>();
            Genre = new List<Genre>();
            TitleParticipant = new List<Titleparticipant>();
            TitleGenre = new List<TitleGenre>();
        }

        public int TitleId { get; set; }
        public string? TitleName { get; set; }
        public string? TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime? ProcessedDateTimeUTC { get; set; }

        //Navgation property
        public List<Awards> Award { get; set; }
        public List<OtherName> OtherNames { get; set; }
        public List<StoryLine> StoryLines { get; set; }
        public List<Participant> Participant { get; set; }
        public List<Titleparticipant> TitleParticipant { get; set; }
        public List<TitleGenre> TitleGenre { get; set; }
        public List<Genre> Genre { get; set; }
    }
}
