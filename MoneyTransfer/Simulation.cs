using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    public class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person person1 = new Person("James", 1000);
            Person person2 = new Person("Michelle", 700);

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            person1.DisplayInfo();
            person2.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            person1.TransferMoney(person2, 200);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            person1.DisplayInfo();
            person2.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }
    }
}
