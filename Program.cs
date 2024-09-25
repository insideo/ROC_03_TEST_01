using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ROC_03_TEST_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = ""; //Zadej jmeno
            string lastName = "";//Zadej prijmeni
            Console.WriteLine("Toto je test c. 1 pro {0} {1} - Prace s poli", firstName, lastName);
            //zeptej se uzivatele jak velke pole (Array) nahodnych cisel se ma vygenerovat
            int lenght = 20; //20 nahrad vysledkem dotazu
            double[] randomArray = CreateArrayOfRandomDoubles(lenght,1,1000);
            Console.Write(ArrayToString(randomArray));
            Console.WriteLine("Prumerna hodnota = {0}",ReturnMeanValue(randomArray));
            (double min, double max) = ReturnMinMax(randomArray);
            Console.WriteLine("Minimalni hodnota = {0}, maximalni hodnota = {1}", min, max);
        }
        /// <summary>
        /// Create function that create array of random numbers of a lenght
        /// </summary>
        /// <returns></returns>
        static double[] CreateArrayOfRandomDoubles(int lengthIn, int lowerBound, int upperBound )
        {
            //Proved kontrolu Pokud je lengthIn mensi nez 0 nebo vetsi nez 100000 pak zadej 100000
            //Pouzij tridu Random
            Random random = new Random();
            //Vygenerovany double .Next double vraci hodnotu od 0 do 1, pokud potrebujeme jine rozmezi mezi lower a upper bound pouzijte toto
            var generatedRandomDouble = random.NextDouble() * (upperBound - lowerBound) + lowerBound;
            
            //Vytvorte pole a ve smycce kaydou poyici naplnte vygenerovanym cislem
            //pak ho vratte, ale serazene od nejmensiho po nejvetsi pouzij metodu Array tridy
            return new double[] { }; //nahrad tuto radku, vrat vyvorene a naplnene pole
                
        }
        static string ArrayToString(double[] array)
        {
            string arrayValues = "";
            return arrayValues + "\n";
            //zkus pouzit foreach nebo jinou smycku. a kazdou hodnotu oddel novou radkou.
        }
        static double ReturnMeanValue(double[] arrayIn)
        {
            ////Projdi ve smycce pole arrayIn a spocitej prumer, ten pak vrat.
            double mean = 0;
            return mean;
        }
        //Funkce muze vracet i dvojici, trojici atd hodnot, tzv. Tupples, Doplnte funkci aby vratila dvojici min, max hodnot z pole.
        //Pokud se ti to nelibi muzes vytvorit funkce dve ReturnMin a ReturnMax kazda bude vracet double.
        static (double, double) ReturnMinMax(double[] arrayIn)
        {
           double min = 0;
           double max = 100;
            //Projdi ve smycce pole arrayIn, zjisti min a max a vrat je.
           return (min, max);
        }


    }
}
