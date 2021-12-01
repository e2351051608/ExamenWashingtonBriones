using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenWashingtonBriones3B
{
    public class CalculodeSueldo : Profesor
    {
        public class CalculodeSueldo
        {
            double preciodehoratrabajada, sueldoporhoras;
            int numerodehorastrabajadas;
            public void Sueldoarecibir(double preciohoratrabajada, int numerodehorastrabajadas)
            {
                this.preciodehoratrabajada = preciohoratrabajada;
                this.numerodehorastrabajadas = numerodehorastrabajadas;
                sueldoporhoras = preciohoratrabajada * numerodehorastrabajadas;
            }
            public double getsueldoporhoras()
            {
                return sueldoporhoras;
            }
            public void setsueldoporhoras(double sueldoporhoras)
            {
                this.sueldoporhoras = sueldoporhoras;
            }

        }
    }
}