using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenWashingtonBriones3B
{
    public class Profesorporcontrato : CalculodeSueldo
    {
        public void Sueldoarecibir(double preciohoratrabajada, int numerodehorastrabajadas)
        {
            this.preciodehoratrabajada = preciohoratrabajada;
            this.numerodehorastrabajadas = numerodehorastrabajadas;
            sueldoporhoras = 800 + preciohoratrabajada * numerodehorastrabajadas;
        }
    }
}