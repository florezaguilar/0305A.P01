using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conversor
{
    class escala
    {
        private static double var1, var2, var3;

        public escala()
        {
            escala.var1 = escala.var2 = escala.var3 = 0;
        }

        public double Var1
        {
            get { return var1; }
            set { var1 = value; }
        }

        public double Var2
        {
            get { return var1; }
            set { var2 = value; }
        }

        public double Var3
        {
            get { return var3; }
            set { var3 = value; }
        }

        public static void C_F(double var2)
        {
            escala.var3 = (escala.var2 * 1.8) + 32;
        }

        public static void C_K( double var2)
        {
            escala.var3 = (escala.var2) + 273.15;
        }


        public static void F_C( double var2)
        {
            escala.var3 = (escala.var2 - 32) / 1.8;
        }

        public static void F_K(double var2)
        {
            escala.var3 = ((escala.var2 - 32) * 5 / 9) + 273;
        }

        public static void K_F(double var2)
        {
            escala.var3 = ((escala.var2 - 273) * 9 / 5) + 32;
        }

        public static void K_C(double var2)
        {
            escala.var3 = (escala.var2) - 273.15;
        }

    }
}
