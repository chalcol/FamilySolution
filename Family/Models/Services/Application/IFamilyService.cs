using Family.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Models.Services.Application
{
   public interface IFamilyService
    {
      public  List<FamilyVieWModel> GetFamily();
      public  DetailsViewModel GetDetails(int id);
    }
}
