using ejercicio.Model;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio.Services


{
    public class alumnosService
    {
        private static List<alumnos> list;

        public alumnosService() 
        {
            list = new List<alumnos>();

            var listaalumnos = new alumnos() { Id = 1, Nombre= "listaalumnos"};

            list.Add(new alumnos() 
            { 
                Id= 1, 
                Nombre = "pablo",
                apellido = "fernandez", 
                edad = "19"
               
            });

            list.Add(new alumnos() 
            { 
                Id= 2, 
                Nombre = "marcos", 
                apellido = "aguilar",
                edad = "20" 
               
            });

            list.Add(new alumnos() 
            { 
                Id= 3, 
                Nombre = "fernando",
                apellido = "martinez" ,
                edad = "18"
               
            });
        }

        public List<alumnos> GetAll() 
        {
            return list;
        }

        public alumnos Get(int id) 
        {
            return list.FirstOrDefault(b => b.Id == id);
        }


        public void Save(alumnos alumnos)
        {
            this.Delete(alumnos.Id);
            list.Add(alumnos);
        }

        public void Delete(int id) 
        {
            var alumnos = this.Get(id);

            if(alumnos != null) 
            {
                list.Remove(alumnos);
            }
        }

    }
}
