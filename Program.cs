using System;

namespace Milestone_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controler obj = new Controler();
            obj.add(new Data(5,"Milk","Eatible",1.99,50,new Owner(1,"Nestle^",1,5)));
            obj.Display();
            if(obj.find(5)!=null)
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not found");
            }
            if(obj.reStock(5, 50))
            {
                Console.WriteLine("Restock Sucessfull");
            }
            else
            {
                Console.WriteLine("Error finding ID");
            }
            obj.Display();
        }
    }
}
