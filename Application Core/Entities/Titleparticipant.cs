using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class Titleparticipant
    {
        //Primary Key
        public int Id { get; set; }
        // Foreign Key
        public int TitleId { get; set; }
        // Foreign Key
        public int ParticipantId { get; set; }
        public bool IsKey { get; set; }
        public string? RoleType { get; set; }
        public bool IsOnScreen { get; set; }

        // Naviagtion
        public Participant Participant { get; set; }
        public Title Title { get; set; }
    }
}
