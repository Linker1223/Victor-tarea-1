using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Entidad
    {
        protected int Vida { get; set; }
        protected int Mana { get; set; }
        protected int ValorAtaque { get; set; }
        protected int ValorDefensa { get; set; }
        ///////////////////////////
        public void Ataque()
        {
            if (ValorAtaque <= 100 && ValorAtaque >= 0)
            {

            }
            else
            {

            }
        }
        public void Mover()
        {
            
        }
        public void Saltar()
        {
            
        }
        public void Defender()
        {
            if (ValorDefensa <= 100 && ValorDefensa >= 0)
            {

            }
            else
            {

            }
        }
        public void Muerte()
        {
             if (Vida <= 100 && Vida >= 0)
             {

             }
             else
             {
                
             }
        }
    }

    class Jugador : Entidad
    {

    }
    class Enemigo : Entidad
    {

    }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
