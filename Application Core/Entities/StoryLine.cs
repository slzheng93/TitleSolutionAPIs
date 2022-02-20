using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class StoryLine
    {
        // Foreign Key
        public int TitleId { get; set; }
        public string? Type { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        //Primary Key
        public int Id { get; set; }

        // Naviagtion
        public Title Title { get; set; }
    }
}
