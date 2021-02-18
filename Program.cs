using System;

namespace Practica_Parcial_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cajero Automático

            #region Detalles
            //Opciones de Bancos
            //Banco FDP INVERSMENTS: Límite de Retiro (20000)
            //Banco Maxwell: Límite de retiro (10000)

            #endregion

            Console.Clear();
            int opcion = 0, mil = 0, q = 0, d = 0, c = 0, opcion1 = 0;

            do
            {
                Console.Write("\nSeleccione su Banco");
                Console.WriteLine("\n" +
                "\n 1.- Banco FDP INVERSMENTS " +
                "\n 2.- Banco Maxwell." +
                "\n 3.- Salir."
                );

                Console.WriteLine("Elija una opción");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("\nBienvenido al Banco FDP INVERSMENTS\n");

                        Console.WriteLine("¿Qué desea hacer?");

                        Console.WriteLine(
                        "\n 1.- Retirar dinero" +
                        "\n 2.- Salir");

                        Console.WriteLine("Elija una opción");
                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Introduzca el monto que desea retirar");

                                int monto = int.Parse(Console.ReadLine());
                                if (monto > 20000)
                                {
                                    Console.WriteLine("No puede retirar {0} porque excede el límite (20000)", monto);
                                }
                                else

                                if (monto % 5 == 0 && mil < 19)
                                {

                                    mil = monto / 1000;
                                    monto = monto % 1000;
                                    q = monto / 500;
                                    monto = monto % 500;
                                    d = monto / 200;
                                    monto = monto % 200;
                                    c = monto / 100;
                                    monto = monto % 100;

                                    Console.WriteLine("\nSe retira\n");
                                    Console.WriteLine("{0} billetes de 1000", mil);
                                    Console.WriteLine("{0} billetes de 500", q);
                                    Console.WriteLine("{0} billletes de 200", d);
                                    Console.WriteLine("{0} billetes de 100", c);

                                }




                                break;

                            case 2:

                                Environment.Exit(0);
                                break;

                        }
                        break;

                    case 2:
                        Console.WriteLine("\nBienvenido al Banco Maxwell\n");

                        Console.WriteLine("¿Qué desea hacer?");

                        Console.WriteLine(
                        "\n 1.- Retirar dinero" +
                        "\n 2.- Salir");

                        Console.WriteLine("Elija una opción");
                        opcion1 = int.Parse(Console.ReadLine());

                        switch (opcion1)
                        {
                            case 1:
                                Console.WriteLine("Introduzca el monto que desea retirar");

                                int monto = int.Parse(Console.ReadLine());
                                if (monto > 10000)
                                {
                                    Console.WriteLine("No puede retirar {0} porque excede el límite (10000)", monto);
                                }
                                else

                                if (monto % 5 == 0)
                                {

                                    mil = monto / 1000;
                                    monto = monto % 1000;
                                    q = monto / 500;
                                    monto = monto % 500;
                                    d = monto / 200;
                                    monto = monto % 200;
                                    c = monto / 100;
                                    monto = monto % 100;

                                    Console.WriteLine("\nSe retira\n");
                                    Console.WriteLine("{0} billetes de 1000", mil);
                                    Console.WriteLine("{0} billetes de 500", q);
                                    Console.WriteLine("{0} billletes de 200", d);
                                    Console.WriteLine("{0} billetes de 100", c);

                                }

                                break;

                            case 2:

                                Environment.Exit(0);

                                break;

                        }
                        break;

                    case 3:

                        Environment.Exit(0);

                        break;

                }

            } while (opcion != 3 && opcion1 != 2);
        }
    }
}

