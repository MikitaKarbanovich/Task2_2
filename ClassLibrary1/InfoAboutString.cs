using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class InfoAboutString
    {
        double averageOfInts = 0;
        double averageOfDoubles = 0;
        ArrayList intStrings = new ArrayList();
        ArrayList doubleStrings = new ArrayList();
        ArrayList otherStrings = new ArrayList();
        public double AverageOfInts
        {
            get
            {
                return this.averageOfInts;
            }
            set
            {
                this.averageOfInts = value;
            }
        }
        public double AverageOfDoubles
        {
            get
            {
                return this.averageOfDoubles;
            }
            set
            {
                this.averageOfDoubles = value;
            }
        }
        public ArrayList IntStrings
        {
            get
            {
                return this.intStrings;
            }
            set
            {
                this.intStrings = value;
            }
        }
        public ArrayList DoubleStrings
        {
            get
            {
                return this.doubleStrings;
            }
            set
            {
                this.doubleStrings = value;
            }
        }
        public ArrayList OtherStrings
        {
            get
            {
                return this.otherStrings;
            }
            set
            {
                this.otherStrings = value;
            }
        }
    }

}
