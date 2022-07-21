using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Ugoll
    {
        int graduS;
        int minutE;
        int seconD;
        public int Gradus
        {
            get
            {
                return graduS;
            }
            set
            {
                if (value > 360)
                {
                    graduS = value % 360;
                }
                else
                {
                    graduS = value;
                }
            }
        }
        public int Minute
        {
            get
            {
                return minutE;
            }
            set
            {
                graduS += value / 60;
                minutE = value % 60;
            }
        }
        public int Second
        {
            get
            {
                return seconD;
            }
            set
            {
                minutE += value / 60;
                seconD = value % 60;
            }
        }
        public Ugoll(int graduS, int minutE, int seconD)
        {
            this.Gradus = graduS;
            this.Minute = minutE;
            this.Second = seconD;
            //Gradus = gradus;
            // Minute = minute;
            // Second = second;
        }
        public double ToRadians()
        {
            return graduS * Math.PI / 180 + minutE / 60 * Math.PI / 180 + seconD / 3600 * Math.PI / 180;
        }
    }
}
