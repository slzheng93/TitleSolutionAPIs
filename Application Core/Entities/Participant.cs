﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Core.Entities
{
    public class Participant
    {
        //Primary Key
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ParticipantType { get; set; }
    }
}
