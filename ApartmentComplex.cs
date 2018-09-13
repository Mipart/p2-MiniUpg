using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUppgiftF
{
    class ApartmentComplex
    {
        List<Apartment> apartments;

        ApartmentComplexCreatorController accc = new ApartmentComplexCreatorController();

        public ApartmentComplex()
        {
            //Hämtar nädvändig data till detta komplex
            apartments = accc.GetApartments();
        }


        public void ChangeApartmentStatus(int number)
        {
            apartments[number].ChangeStatus();
        }

        public List<string> GetApartmentns()
        {
            List<string> info = new List<string>();
            if(apartments.Count > 0)
                foreach (Apartment apart in apartments)
                {
                    info.Add(apart.ToString());
                }
            return info;
        }
    }
}
