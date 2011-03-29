using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmerPlusDataObjectLayer
{
    public class Phone_Ranges
    {
        private string start_range;
        private string end_range;

        public string Start_Range
        {

            set { start_range = value; }
            //get the person name 
            get { return start_range; }
        }

        public string End_Range
        {

            set { end_range = value; }
            //get the person name 
            get { return end_range; }
        }
    }
}
