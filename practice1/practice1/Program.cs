using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            String yela;
            yela = "Yela Wood is genine";

            Console.WriteLine(yela);

            practice1.Person myPerson = new Person();
            myPerson.FirstName = "Mason";
            myPerson.LastName = "Gaither";
            myPerson.Addr1 = "123 Lindo Drive";
            myPerson.City = "Boaz";
            myPerson.State = "AL";
            myPerson.Zip = "35956";
            myPerson.Phone1 = "2566131965";

            string allString = myPerson.FirstName + " " + myPerson.LastName + " " + myPerson.Addr1 + " " + myPerson.City + " " + myPerson.State + " " + myPerson.Zip;
            Console.WriteLine(allString);


            String cont = Console.ReadLine();
            if (cont == "yes")
            {
                Console.WriteLine(myPerson.MailingLabel());
                Console.WriteLine(myPerson.Zip);
                myPerson.Semi();
                Console.ReadLine();
            }

            


           
            
           

        }
    }
}
