using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordbok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 1
            Dictionary<string, double> varepriser = new Dictionary<string, double>(); //Definerer et nytt Dictionary med string key of double value
            varepriser.Add("Melk", 14.90); //Legger til verdien 14.90 med key-en Melk
            varepriser.Add("Brød", 24.90);
            varepriser.Add("Yoghurt", 12.90);
            varepriser.Add("Pizza", 39.90);
            foreach (KeyValuePair<string, double> i in varepriser) //Gjenntas for hvert par med verdi og key, dette parret er i
            {
                Console.WriteLine($"Key = {i.Key}, Value = {i.Value}"); //Skriver ut par i sin key og value
            }

            //Oppg 2
            string temp1; //Forbreder variablene
            double temp2;
            string temp3;

            for (int i = 0; i < 2; i++) //Kjører 2 ganger
            {
                Console.WriteLine("Hva er navnet på den nye varen?");
                temp1 = Console.ReadLine();
                while (true) //Kjører helt til brukeren gir et gyldig tall
                {
                    Console.WriteLine("Hva er prisen på denne varen?");
                    temp3 = Console.ReadLine();
                    try
                    {
                        if (temp3.Contains(",")) //Passer på at brukeren ikke bruker komma fordi det da ikke blir desimaler (14,90 = 1490)
                        {
                            Console.WriteLine("Vennligst bruk '.'");
                        } else
                        {
                            temp2 = Convert.ToDouble(temp3); //Converterer til double
                            break; //Bryter løkken
                        }
                    }
                    catch //Kjører hvis brukeren ikke oppgir en gyldig tallverdi
                    {
                        Console.WriteLine("Vennligst oppgi en tallverdi");
                    }
                }
                varepriser.Add(temp1, temp2); //Legger til dne nye gjennstanden til ordboken
            }
            foreach (KeyValuePair<string, double> i in varepriser)
            {
                Console.WriteLine($"Key = {i.Key}, Value = {i.Value}");
            }

            Console.ReadLine();
        }
    }
}
