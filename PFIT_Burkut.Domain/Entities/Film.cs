using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFIT_Burkut.Domain.Entities
{
   public class Film:Base
    {
        public string Title { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Country { get; set; }
        public string Producer { get; set; }
        public string Genre { get; set; }
        public DateTime Time { get; set; }
    }
}
