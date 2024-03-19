﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    interface IVehiculo
    {
        void acelerar(int kmh);
        void frenar();
        void girar(int angulos);
    }

    class Automovil : IVehiculo
    {
        public void acelerar(int kmh)
        {
            Console.WriteLine($"Acelerando {kmh} kmh...");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando...");
        }

        public void girar(int angulos)
        {
            Console.WriteLine($"Girando {angulos} grados...");
        }
    }
}
