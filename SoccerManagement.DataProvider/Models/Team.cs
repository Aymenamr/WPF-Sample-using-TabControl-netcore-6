using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManagement.DataProvider.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
