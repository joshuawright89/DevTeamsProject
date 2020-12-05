using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    class ProgramUI
    {
        //Method that runs the app
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            //Display options
            Console.WriteLine("Select an option:\n" +
                "1. Add new Developer\n" +
                "2. View existing Developers\n" +
                "3. View Developers by name\n" +
                "4. View Developers by ID number\n" +
                "5. Update existing Developer profile\n" +
                "6. Delete existing Developer profile\n" +
                "7. Exit.");

            //Get user's input
            string input = Console.ReadLine();

            //Act according to user's input
            switch (input)
            {
                case "1":
                    //Create
                    break;
                case "2":
                    //View existing
                    break;
                case "3":
                    //View By name
                    break;
                case "4":
                    //View by ID
                    break;
                case "5":
                    //Update
                    break;
                case "6":
                    //Delete
                    break;
                case "7":
                    //Exit
                    break;
                default:
                    Console.WriteLine("Please enter a value number (#1-7).");
                    break;
            }
        }




    }
}
