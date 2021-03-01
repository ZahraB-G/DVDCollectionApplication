//Zahra Bodaghi-Ginns    Spring Semster 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace DVDCollectionApplication
{
    class DVD
    {
        
        public string title;
        public string category;
        public double time;
        public int releasedYear;
        public double price;
        public DVD()
        {

        }
        public DVD(string t, string c, double ti, int r, double p)
        {
            title = t;
            category = c;
            time = ti;
            releasedYear = r;
            price = p;

        }
    }
}
