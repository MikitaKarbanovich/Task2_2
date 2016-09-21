using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class InfoAboutString
    {
        int intCounter = 0;
        int doubleCounter = 0;
        double averageOfInts = 0;
        double averageOfDoubles = 0;
        ArrayList intStrings = new ArrayList();
        ArrayList doubleStrings = new ArrayList();
        ArrayList otherStrings = new ArrayList();
        public int IntCounter
        {
            get
            {
                return this.intCounter;
            }
            set
            {
                this.intCounter = value;
            }
        }
        public int DoubleCounter
        {
            get
            {
                return this.doubleCounter;
            }
            set
            {
                this.doubleCounter = value;
            }
        }
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
