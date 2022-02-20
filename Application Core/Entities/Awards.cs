using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class Awards
    {
        // Foreign Key
        public int TitleId { get; set; }
        public bool? AwardWon { get; set; }
        public int? AwardYear { get; set; }
        public string Award { get; set; }
        public string AwardCompany { get; set; }
        //Primary Key
        public int Id { get; set; }

        // Naviagtion
        public Title Title { get; set; }
    }
}
