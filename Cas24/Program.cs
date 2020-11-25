using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Qa Telefonski imenik \n");
                Console.WriteLine("1.Unos novog imena");
                Console.WriteLine("2.Listanje imenika");
                Console.WriteLine("3. Pretraga");
                Console.WriteLine("Q kraj rada");
                Choice = Console.ReadLine();
                switch (Choice.ToUpper())
                {
                    case "1":
                       
                        break;
                    case "2":
                       
                        break;
                    case "3":
                        
                        break;
                    case "Q":
                        break;
                    default:
                        break;

                }
            }while(Choice.ToUpper() != "Q");

            static void AddNewName()
            {
                string FirstName, LastName, Adress, Phone;
                FirstName = Important.GetUserInput("Unesite ime");
                LastName = Important.GetUserInput("Unesite prezime");
                email = Important.GetUserInput("Unesite email");
                

                FileX.Write(FirstName, LastName, email);
            }
        }
        
    }
    
}
    

