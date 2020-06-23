using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Models.ViewModels
{
    public class FamilyVieWModel
    {
        public int Id { set; get; }
        public String Nome { get; set; }
        public String Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public String Status { get; set; }
    }
}
