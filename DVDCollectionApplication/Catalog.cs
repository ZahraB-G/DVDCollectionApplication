
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DVDCollectionApplication
{
    class Catalog
    {
        public const int MAX_SIZE = 100;
        DVD[] DVDs = new DVD[MAX_SIZE];
        int currentDVD = 0;
   
        public void addDVD(string title, string category, double time, int releasedYear, double price)
        {
            DVD newDVD = new DVD(title, category,time, releasedYear,price);
            
            if(currentDVD != MAX_SIZE)
            {
                DVDs[currentDVD++] = newDVD;
                Console.WriteLine("Added a new DVD to our Collection!");
            }
            else
            {
                Console.WriteLine("Our Collection is full at this time");
            }
           
        }
        public void removeDVD(string title)
        {
            ////This is a dummy method since it is not required for our assignment to be implemented
            Console.WriteLine(title + " has been removed from our Collection");  
        }
        public void editDVD(string title, string category, double time, int releasedYear, double price)
        {
            //This is a dummy method 
            Console.WriteLine(title + "has been removed from our Collection");
        }
        public void displayDVDByYear(int year)
        {
            
            Console.WriteLine("We do not have any DVD that have been released in this year");
            
        }
        public void displayDVDByCatalog(string category)
        {
            if (DVDs == null)
            {
                Console.WriteLine("There is nothing to display");
                return;
            }
            
           for (int i = 0; i < currentDVD; i++)
            {
                    if (DVDs[i].category.Equals(category, StringComparison.OrdinalIgnoreCase))
                     {
                         Console.WriteLine(DVDs[i].title);//display the title of the DVD
                     }
             }
 
        }

        public void restoreCataloge()
        {
             
            string line;
            int counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"catalog.txt");
            List<string> s = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                s.Add(line);
                counter++;
            }
            char delima = ',';
            DVD newDVD = new DVD();
            for (int i = 0; i <counter; i++)
            {
                
                newDVD.title = s[i].Split(delima)[0];
                newDVD.category = s[i].Split(delima)[1];
                newDVD.time = Convert.ToDouble(s[i].Split(delima)[2]);
                newDVD.releasedYear = Convert.ToInt32(s[i].Split(delima)[3]);
                newDVD.price = Convert.ToDouble(s[i].Split(delima)[4]);
                DVDs[currentDVD] = newDVD;
                currentDVD++;
                newDVD = new DVD();
             }
            file.Close();
           

        }
        
        public void saveCatalog()
        {
            string[] s = new string[currentDVD];
            for (int i = 0; i < currentDVD; i++)
                s[i] = DVDs[i].title + ',' + DVDs[i].category + ',' + DVDs[i].time + ',' + DVDs[i].releasedYear + ',' + DVDs[i].price;
            File.WriteAllLines("catalog.txt", s);
           


        }
    }

}
