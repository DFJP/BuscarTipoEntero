using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarTipoEntero
{
    class Program
    {
        static void Main(string[] args)
        {
            //object[] tipos = CrearArregloINT();
            //object[] tipos = CrearArregloDOUBLE();
            //object[] tipos = CrearArregloSTRING();
            //object[] tipos = CrearArregloEstatico();
            object[] tipos = CrearArregloDinamico();
            if (!BuscarEntero(tipos))
                Console.WriteLine("No se encontro un elemento de tipo entero \n");
            ImprimirArreglo(tipos);
        }

        public static void ImprimirArreglo(object[] tipos)
        {
            int i;
            Console.WriteLine("\nVariable\t Tipo");
            for (i = 0; i < tipos.Length; i++)
                Console.WriteLine(tipos[i].ToString() + "\t\t" + tipos[i].GetType());

            Console.Read();
        }

        public static bool BuscarEntero(object[] tipos)
        {
            int i;

            for (i = 0; i < tipos.Length; i++)
                if (tipos[i].GetType() == Type.GetType("System.Int32"))
                {
                    Console.WriteLine("Valor Entero: " + tipos[i].ToString());
                    return true;
                }

            return false;
        }
        /// <summary>
        /// Método para generar un arreglo de tipo int
        /// </summary>
        /// <returns>enteros</returns>
        public static object[] CrearArregloINT()
        {
            return new object[] { 5, 4, 3, 2, 1 };
        }

        /// <summary>
        /// Método para generar un arreglo de tipo double
        /// </summary>
        /// <returns>doubles</returns>
        public static object[] CrearArregloDOUBLE()
        {
            return new object[] { 1.34, 2.0, 9.43, 10.23, 10.0 };
        }

        /// <summary>
        /// Método para generar un arreglo de tipo string
        /// </summary>
        /// <returns></returns>
        public static object[] CrearArregloSTRING()
        {
            return new object[] { "1", "2", "3", "4", "5" };
        }

        /// <summary>
        /// Método para generar un arreglo estático con diferentes tipos de datos
        /// </summary>
        /// <returns></returns>
        public static object[] CrearArregloEstatico()
        {
            return new object[] { "arreglo", 1.28, true, 'T', 5 };
        }

        /// <summary>
        /// Método para generar un arreglo dinámico con diferentes tipos de datos
        /// </summary>
        /// <returns></returns>
        public static object[] CrearArregloDinamico()
        {
            int i;
            object[] tipos = new object[10];
            Random r = new Random();

            for (i = 0; i < 10; i++)
            {
                switch (r.Next(3))
                {
                    case 0: //INT
                        tipos[i] = r.Next(999);
                        break;
                    case 1: //DOUBLE
                        tipos[i] = Convert.ToDouble(r.Next(999).ToString() + "." + r.Next(999).ToString());
                        break;
                    case 2: //STRING
                        tipos[i] = Convert.ToString(r.Next(999).ToString() + r.Next(999).ToString());
                        break;
                }
            }
            return tipos;
        }
    }
}
