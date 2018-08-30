using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentMyWrox.Models
{
    public class UseDemoGraphics
    {
        public UseDemoGraphics()
        {
            Hobbies = new List<string>();
        }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateMovedIntoArea { get; set; }
        public bool OwnHome { get; set; }
        public int TotalPeopleInHome { get; set; }
        public List<string> Hobbies { get; set; }

    }
}