using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniUppgiftF
{
    class ApartmentComplexCreatorController
    {
        List<Apartment> aprtList = new List<Apartment>();
        
        public ApartmentComplexCreatorController()
        {
            GenerateNewComplex();
        }

        //Går igenom de tre stadierna för att skapa lägenehter; Förbestämda lägnheter(3), Lägenheter som man får välja hur många rum de har(3) och den sista som tar hänsyn till hur många lägenhetr som är kvar i slutet.
        void GenerateNewComplex()
        {
            bool r = true; //Kontroll variabel för att se om man lyckades skapa ett komplex
            while (r)
            {
                int maxRooms = 20;

                aprtList.Clear();
                for (int i = 0; i < 3; i++)
                {
                    Apartment nAprt = new Apartment(i + 1, (MessageBox.Show($"Apartment : {i+1}\nIs this apartment Occupied?", "Apartment Status", MessageBoxButtons.YesNo) == DialogResult.Yes));
                    aprtList.Add(nAprt);
                }

                maxRooms -= 6;


                for (int i = 0; i < 3; i++)
                {
                    maxRooms -= CreateApartment(i+4);
                }

                if(maxRooms > 0 && maxRooms <= 4)
                {
                    r = false;
                    Apartment nAprt = new Apartment(maxRooms, (MessageBox.Show("Apartment: 7\nIs this apartment Occupied?", "Apartment Status", MessageBoxButtons.YesNo) == DialogResult.Yes));
                    aprtList.Add(nAprt);
                }
                else
                {
                    MessageBox.Show("Something went wrong! Please try again", "ERROR:Something Went Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Metod för att skapa enstaka lägenheter, iterarar denna metod flera ggr i metoden GenerateComplex
        int CreateApartment(int index = 0)
        {
            using(ApartmentComplexCreator aprtCC = new ApartmentComplexCreator(index))
            {
                if(aprtCC.ShowDialog() == DialogResult.OK)
                {
                    Apartment aprt = aprtCC.GetApartment();
                    aprt = new Apartment(ClampInt(aprt.NumberOfRooms), aprt.Status);
                    aprtList.Add(aprt);
                    return aprt.NumberOfRooms;
                }
            }

            return 0;
        }

        int ClampInt(int input)
        {
            if (input > 4)
                input = 4;
            if (input < 0)
                input = 1;
            return input;
        }

        //För att komma åt själva komplexet.
        public List<Apartment> GetApartments()
        {
            return aprtList;
        }
    }

   
}
