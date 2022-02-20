using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class OtherName
    {
        // Foreign Key
        public int? TitleId { get; set; }
        public string? TitleNameLanguage { get; set; }
        public string? TitleNameType { get; set; }
        public string? TitleNameSortable { get; set; }
        public string? TitleName { get; set; }
        public int Id { get; set; }

        // Naviagtion
        public Title Title { get; set; }
    }
}
