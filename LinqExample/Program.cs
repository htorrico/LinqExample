using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Entity;
namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BPerson bPerson = new BPerson();
            #region Where
            //Muestra todas las personas de Nasca

            //var resul = bPerson.GetBPeopleFromNascaLambda();

            //foreach (var item in resul)
            //{
            //    Console.WriteLine(item.FirstName);
            //}



            var resul2 = bPerson.GetGroup();

            foreach (var item in resul2)
            {
                Console.WriteLine(item.City);
                Console.WriteLine(item.Cant);
            }

            Console.Read();
            #endregion
        }
    }
}
