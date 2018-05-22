using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using ClassLibrary1;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp2
{
    class Program
    {
        [DllImport("ClassLibraryBueno")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        static void Main(string[] args)
        {
            Registro nuevoregistro = new Registro();
            
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Read);
                nuevoregistro = (Registro)bin.Deserialize(stream);
                stream.Close();
            }

            Console.WriteLine("Bienvenido al registro civil");
            Console.WriteLine("Menu: ");
            Console.WriteLine("a) Inscribir Persona");
            Console.WriteLine("b) Inscribir Propiedades");
            Console.WriteLine("c) Inscribir Automovil");
            
            Console.WriteLine("Escriba su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Escriba su fecha de nacimiento de la forma yyyy - MM - dd HH");
            string fecha = Console.ReadLine();
            DateTime fechanacimiento = DateTime.ParseExact(fecha, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Escriba su direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Escriba su rut");
            string rut = Console.ReadLine();
            //Person nuevapersona = new Person(nombre, apellido, fechanacimiento, direccion, rut, );
            BinaryFormatter bin2 = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin2.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin2.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            

        }
    }
}
