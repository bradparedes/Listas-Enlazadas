using course;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Course
{
    class Program
    {


        static void Main()
        {
            var list = new ListaNodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.ListaVacia();
            Console.ReadKey();
        }

    }

}