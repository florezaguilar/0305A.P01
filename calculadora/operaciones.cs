using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora

{
    class operaciones
    {
#region Metodos
        private static double rpta;
        private static double var1;
        private static double var2;
        
        public double Rpta
        {
            get  
            {
                return rpta;
            }
            set  
            {
                rpta=value;
            }
        }

        public double Var1
        {
            get 
            { 
                return var1; 
            }
            set 
            { 
                var1 = value; 
            }
        }

        public double Var2
        {
            get 
            { 
                return var2; 
            }
            set
            { 
                var2 = value; 
            }
        }

        public operaciones()
        {
            operaciones.rpta = 0;
            
        }
#endregion

#region  Metodos

               
        public static void suma(double var1,double var2)
        {
            operaciones.rpta = operaciones.var1 + operaciones.var2;
            
        }


        public static void resta(double var1, double var2)
        {
            operaciones.rpta = operaciones.var2 - operaciones.var1;
        }

        public static void multiplicacion(double var1, double var2)
        {

            operaciones.rpta = operaciones.var1 * operaciones.var2;
        }


        public static void division(double var1, double var2)
        {
            if (var1 == 0)
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
            else
                operaciones.rpta = operaciones.var2 / operaciones.var1;
        }


        public static double getRpta()
        {
            return operaciones.rpta;
        }


        public static void limpiar()
        {
            operaciones.rpta = 0;
        }
    }
}
#endregion