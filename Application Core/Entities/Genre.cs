using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class Genre
    {
        //Primary Key
        public int Id { get; set; }
        public string Name { get; set; }

        // Naviagtion
        public List<TitleGenre> TitleGenres { get; set; }
    }
}
