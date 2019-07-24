using ejercicio.Model;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio.Services
{
    public interface  Alumnos
    {
        List<Alumnos> GetAll();
        Alumnos Get(int id);
        void Save(Alumnos alumnos);
        void Delete(int id);
    }
}
