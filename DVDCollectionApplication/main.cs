
using System;


namespace DVDCollectionApplication
{
    class main
    {
        static void Main(string[] args)
        {
            //create the instance of the controller class
            Controller control = new Controller();
            //call the control.UCrestoreCatalog() of the Controller class to read the catalog from the "Catalog.txt" file
            control.UCrestoreCataloge();
            //create the instance of the view class
            View view = new View();
            //call the view.showSelection() of the View class to display the menu of options for Actor user
            view.showSelection();
            int choice;
            string title;
            string catagory;
            double time;
            int releasedYear;
            double price;
            Console.WriteLine("What is your choice");
            choice =Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1 :
                    {
                        Console.WriteLine("What is the title of DVD");
                        title = Console.ReadLine();
                        Console.WriteLine("What is the category of DVD");
                        catagory = Console.ReadLine();
                        Console.WriteLine("What is the running time");
                        time = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the year of release");
                        releasedYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How much the DVD cost");
                        price = Convert.ToDouble(Console.ReadLine());
                        control.UCAddDVD(title, catagory, time,releasedYear,price);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("What is the title of DVD that you want to remove");
                        title = Console.ReadLine();
                        control.UCRemoveDVD(title);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("What is the title of DVD that you want to edit its information");
                        title = Console.ReadLine();
                        Console.WriteLine("What is the category of DVD");
                        catagory = Console.ReadLine();
                        Console.WriteLine("What is the running time");
                        time = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("What is the year of release");
                        releasedYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("How much the DVD cost");
                        price = Convert.ToDouble(Console.ReadLine());
                        control.UCEditDVD(title, catagory, time, releasedYear, price);
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("What category of DVDs would you like to be displayed");
                        catagory = Console.ReadLine();
                        control.UCDisplayDVDByCatalog(catagory);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("What year DVDs would you like to be displayed");
                        releasedYear = Convert.ToInt32(Console.ReadLine());
                        control.UCDisplayDVDByYear(releasedYear);
                        break;
                    }
                default:
                    Console.WriteLine("The choice you enter is not part of our options");
                    break;
             }
            control.UCsaveCatalog();


        }
    }
}
