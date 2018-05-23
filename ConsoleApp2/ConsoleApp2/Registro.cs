using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp2
{
    public class Registro
    {
        List<Person> listapersonas;
        List<Address> listapropiedades;
        List<Car> listaautos;

        public void AgregarListaPersonas(Person persona)
        {
            listapersonas.Add(persona);
        }

        public void AgregarListaPropiedaes(Address propiedad)
        {
            listapropiedades.Add(propiedad);
        }

        public void AgregarListaAutos(Car autos)
        {
            listaautos.Add(autos);
        }

    }
}
