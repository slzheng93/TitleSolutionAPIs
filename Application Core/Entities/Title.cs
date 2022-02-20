using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class Title
    {
        //Primary Key
        public int TitleId { get; set; }
        public string? TitleName { get; set; }
        public string? TitleNameSortable { get; set; }
        public int? TitleTypeId { get; set; }
        public int? ReleaseYear { get; set; }
        public DateTime? ProcessedDateTimeUTC { get; set; }

        // Naviagtion
        public List<Awards> Award { get; set; }
        public List<OtherName> OtherNames { get; set; }
        public List<StoryLine> StoryLines { get; set; }
        public List<Titleparticipant> TitleParticipants { get; set; }
        public List<TitleGenre> TitleGenres { get; set; }
    }
}
