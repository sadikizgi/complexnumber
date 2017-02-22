using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB22022017
{
    class complex
    {
        private double reel;                // instance variable
        private double  imagener;          // instance variable

        public double Reel
        {
            get
            {
                return reel;
            }

            set
            {
                reel = value;
            }
        }

        public double Imagener
        {
            get
            {
                return imagener;
            }

            set
            {   if (imagener > 0)
                    imagener = value;
                else
                {
                    Console.WriteLine("sayı sıfırdan küçük olamaz !!");
                }
            }
        }

        public complex() { }

        public complex(double reel , double imagener)
        {
            this.reel = reel;
            this.imagener = imagener;
        }
        public static complex Complex_FromCartesian(double reel, double imagener)
        {
            return new complex(reel, imagener);
        }

        public static complex Complex_FromPolar(double mod , double arg)
        {
            double reel = mod * Math.Cos(arg);
            double imagener = mod * Math.Sin(arg);
            return new complex(reel, imagener);
        }

        public void add(complex num2)
        {
            this.reel = this.reel + num2.reel;
            this.imagener = this.imagener + num2.imagener;
        }

        public void Substract (complex num2)
        {
            this.reel = this.reel - num2.reel;
            this.imagener = this.imagener - num2.imagener;
        }

        public  static complex Add(complex num1 , complex num2)
        {
            return new complex(num1.reel + num2.reel, num1.imagener + num2.imagener);
        }

        public static complex Substract(complex num1, complex num2)
        {
            return new complex(num1.reel - num2.reel, num1.imagener - num2.imagener);
        }

        public void Multiply (complex num2)
        {
            this.reel = (this.reel) * (num2.reel) - (this.imagener) * (num2.imagener);       //     reel = ac-bd  this formul
            this.imagener = (this.imagener) * (num2.reel) + (this.reel) * (num2.imagener);   // imagener = bc+ad
        }

        public static complex Multiply(complex num1 , complex num2)
        {
            return new complex((num1.reel) * (num2.reel) - (num1.imagener) * (num2.imagener), (num1.imagener) * (num2.reel) + (num1.reel) * (num2.imagener));
        }

    }
}
