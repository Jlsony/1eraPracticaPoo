using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExamples.Vehicles
{
    internal class Car
    {
        public int Cilinders { get; set; }

        public int GasLtsCapacity { get; set; }

        public double GasLts { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Indica si el vehiculo está en marcha
        /// </summary>
        public bool IsOn { get; set; }

        /// <summary>
        /// Cantidad de KM que recorre por Litros
        /// </summary>
        public int Perfonmance { get; set;}


        /// <summary>
        /// Inicializa un objeto de tipo Auto
        /// </summary>
        /// <param name="cilinders">Cantidad de cilindros de l motor</param>
        /// <param name="capacity">Capacidad en litros del tanque</param>
        /// <param name="name">Identificador del vehiculo</param>
        public Car(int cilinders, int capacity, string name) 
        { 
            Cilinders = cilinders;
            GasLtsCapacity = capacity;
            GasLts = 10; //inicialice en 10 y esta inicializado en 0
            Name = name;

            switch (cilinders )
            {
                case 4:
                    Perfonmance = 15;
                    break;

                case 6:
                    Perfonmance = 11;
                    break;

                case 8:
                    Perfonmance = 8;
                    break;

                case 12:
                    Perfonmance = 6;
                    break;

                    default:
                    Console.WriteLine($"{name}** Cantidad de cilindros Inválidos");
                    break;
            }
        }

        /// <summary>
        /// Llena el tanque adicionando los litros de gasolina enviados
        /// </summary>
        /// <param name="lts">Litros de gasolina</param>
        public void FillGas(int lts)
        {
            if ((GasLts + lts) > GasLtsCapacity)
            {
                Console.WriteLine($"{Name}** No se puede realizar la carga por que excede la capacidad");
            }
            else
            {
                GasLts = GasLts + lts;
            }
            
        }

        public void Run(double kilometers)
        {
            if (Perfonmance == 0)
            {
                Console.WriteLine($"{Name}** No se puede arrancar, cilindros inválidos: {Cilinders}");

            }
            else 
            {
                if (GasLts > 0)
                {
                    Console.WriteLine($"{Name}** Inicia a correr con {GasLts} litros");
                    Console.WriteLine($"{Name}** Este auto tiene {Cilinders} cilindros");
                    Console.WriteLine($"{Name}** Y almacena {GasLtsCapacity} litros de gasolina");
                    IsOn = true;

                    double consumo = kilometers / Perfonmance;
                    if (consumo >= GasLts )
                    {
                        GasLts =   consumo - GasLts; //inverti la ecuacion que era: GasLts = GasLts - consumo, por que registraba en consola un resto en negativo.
                        Console.WriteLine($"{Name}** Se recorrieron {kilometers} kilometros y restan {GasLts} litros de gasolina");
                    }
                    else 
                    {
                        double KmRecorridos = kilometers / Perfonmance;
                        Console.WriteLine($"{Name}** Solo se recorrieron {KmRecorridos} kilometros");
                    }

                }
                else
                {
                    Console.WriteLine($"{Name}** No se puede iniciar por que el tanque esta vacio");
                    IsOn = false;
                }
            }

            
           
        }

        public void Stop()
        {
            if (IsOn)
            {
                Console.WriteLine($"{Name}** El auto se detiene");
            }
            else
            {
                Console.WriteLine($"{Name}** El auto ya estaba detenido");
            }

           
        }
    }
}
