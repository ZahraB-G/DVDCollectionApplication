//Zahra Bodaghi-Ginns    Spring Semster 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace DVDCollectionApplication
{
    class Controller
    {
        //create the instance of the catalog class
        Catalog catalog = new Catalog();
        public void UCrestoreCataloge()
        {
            catalog.restoreCataloge();
        }

        public void UCAddDVD(string title, string category, double time, int releasedYear, double price)
        {
            catalog.addDVD(title, category, time, releasedYear, price);
        }
        public void UCRemoveDVD(string title)
        {
            catalog.removeDVD(title);
        }
        public void UCEditDVD(string title, string category, double time, int releasedYear, double price)
        {
            catalog.editDVD(title, category, time, releasedYear, price);
        }
        public void UCDisplayDVDByCatalog(string category)
        {
            catalog.displayDVDByCatalog(category);
        }
        public void UCDisplayDVDByYear(int releasedYear)
        {
            catalog.displayDVDByYear(releasedYear);
        }
        public void UCsaveCatalog()
        {
            catalog.saveCatalog();
        }

    }
}
