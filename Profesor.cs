using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenWashingtonBriones3B
{
    public class Profesor
    {
        private string Nombres;
        private string Apellidos;
        private string Dirección;
        private int Cédulaidentidad;

        public Profesor(string Nombres, string Apellidos, string Dirección, int Cédulaidentidad)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Dirección = Dirección;
            this.Cédulaidentidad = Cédulaidentidad;
        } 
        public string getNombres()
        {
            return Nombres;
        }
        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }

        public string getApellidos()
        {
            return Apellidos;
        }
        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }
        public string getDirección()
        {
            return Dirección;
        }
        public void setDirecciónL(string Dirección)
        {
            this.Dirección = Dirección;
        }
        public int getCédulaidentidad()
        {
            return Cédulaidentidad;
        }
        public void setCédulaidentidad(int Cédulaidentidad)
        {
            this.Cédulaidentidad = Cédulaidentidad;
        }
        public void INFORMACION()
        {
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("                              INFORMACION                       ");
            Console.WriteLine("///////////////////////////////////////////////////////////////\n");


            Console.WriteLine("Nombres: " + getNombres());
            Console.WriteLine("Apellidos: " + getApellidos());
            Console.WriteLine("Dirección: " + getDirección());
            Console.WriteLine("Cédulaidentidad: " + getCédulaidentidad());

            Console.ReadKey();
        }

    }
}