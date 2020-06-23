using Family.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Family.Models.Services.Application
{
    public class FamilyService : IFamilyService
    {
       
        public List<FamilyVieWModel> GetFamily()
        {
            var family = new List<FamilyVieWModel>();

            for (int i = 0; i <= 3; ++i) {
                var familyMember = new FamilyVieWModel
                {
                    Id = i,
                    Nome = "Nome",
                    Cognome = "Cognome",
                    Status = "Status",
                    DataNascita = DateTime.Now
                };

                family.Add(familyMember);
        };
            return family;
        }

        public DetailsViewModel GetDetails(int id)
        {
            var rand = new Random();
            var details = new DetailsViewModel
            {
                Id = id,
                Nome = "Member's first name",
                Cognome = "Member's last name ",
                Status = "Member's status",
                DataNascita = DateTime.Now,
                Età =(Int32)rand.NextDouble()

            };

            return details;
        }
    }
}
