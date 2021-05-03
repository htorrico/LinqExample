using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Business
{
  public  class CityGroup
    {
        public string City { get; set; }
        public int Cant { get; set; }
    }

   public class BPerson
    {
        DPerson dPerson = new DPerson();
        public List<Person> GetBPeopleFromNasca()
        {
            //Obtienes todas las personas
            var list = dPerson.Get();
            var resul = from c in list
                        where c.City=="Nasca"
                        select c
                        ;
           
            return resul.ToList();

        }

        public List<Person> GetBPeopleFromNasca31()
        {            
            var list = dPerson.Get();
            var resul = from c in list
                        where c.City == "Nasca" && c.Age>31
                        select c
                        ;           
            return resul.ToList();

        }

        public List<Person> GetBPeopleAsc()
        {
            var list = dPerson.Get();
            var resul = from c in list                        
                        orderby c.FirstName
                        select c                        
                        ;
            return resul.ToList();

        }

        public List<Person> GetBPeopleFromNascaLambda()
        {
            return dPerson.Get().Where(x => x.City == "Nasca").ToList();
        }


        public List<CityGroup> GetGroup()
        {
            //Obtienes todas las personas
            var list = dPerson.Get();
            var resul = from c in list
                        group c by c.City into cGroup
                        select new CityGroup
                        {
                            City = cGroup.Key,
                            Cant= cGroup.Count()    
                        }
                            ;

            return resul.ToList();

        }
    }
}
