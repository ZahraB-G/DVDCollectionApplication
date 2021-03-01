//Zahra Bodaghi-Ginns     Spring Semster 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace DVDCollectionApplication
{
    class View
    {
        public void showSelection()
        {
            Console.WriteLine("Welcome to the DVD Collection Application");
            Console.WriteLine("Enter 1 for adding DVD ");
            Console.WriteLine("Enter 2 for removing DVD ");
            Console.WriteLine("Enter 3 for editing DVD ");
            Console.WriteLine("Enter 4 for displaying DVD by catalog ");
            Console.WriteLine("Enter 5 for displaying DVD by year");
        }
    }
}
