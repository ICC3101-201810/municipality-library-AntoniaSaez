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
        [DllImport("ClassLibrary1")]
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
            string respuesta = Console.ReadLine();

            if (respuesta == "a")
            {
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
                Console.WriteLine("Opciones: ");
                Console.WriteLine("a) Cambiar de nombre ");
                Console.WriteLine("b) Cambiar de apellido ");
                Console.WriteLine("c) Ser abandonado ");
                Console.WriteLine("d) Ser adoptado");
                Console.WriteLine("e) Dejar en custodia de un tercero ");
                Console.WriteLine("f) Educacion ");
                string respPersona = Console.ReadLine();
                if (respPersona == "a")
                {
                    Console.WriteLine("Escriba el nombre que desea ");
                    string nuevonombre = Console.ReadLine();
                    //persona.changeFirstName(nuevonombre)

                }
                if (respPersona == "b")
                {
                    Console.WriteLine("Escriba el apellido que desesa ");
                    string nuevoapellido = Console.ReadLine();
                    //persona.changeLastName(nuevoapellido)
                }
                if (respPersona == "c")
                {
                    //persona.getAbandoned()
                }
                if (respPersona == "d")
                {
                    //Person padre = new Person()
                    //persona.getAdopted(padre);
                }
                if (respPersona == "e")
                {
                    //Person nuevotutor = new Person()
                    //persona.giveUpOwnershipToThirdParty(nuevotutor)
                }
                if (respPersona == "f")
                {

                }
            }
            if (respuesta == "b")
            {

            }


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
