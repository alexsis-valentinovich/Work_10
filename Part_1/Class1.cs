using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Ugoll
    {
        double graduS;
        double minutE;
        double seconD;
        public double Gradus
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
        public double Minute
        {
            get
            {
                return minutE;
            }
            set
            {
                graduS += Math.Truncate(value / 60);
                minutE = value % 60;
            }
        }
        public double Second
        {
            get
            {
                return seconD;
            }
            set
            {
                minutE += Math.Truncate(value / 60);
                seconD = value % 60;
            }
        }
        public Ugoll(double graduS, double minutE, double seconD)
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
