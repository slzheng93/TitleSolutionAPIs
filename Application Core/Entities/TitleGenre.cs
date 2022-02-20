using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class TitleGenre
    {
        //Primary Key
        public int Id { get; set; }
        // Foreign Key
        public int TitleId { get; set; }
        // Foreign Key
        public int GenreId { get; set; }

        // Naviagtion
        public Genre Genre { get; set; }
        public Title Title { get; set; }
    }
}
