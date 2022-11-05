using CCFF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFFF.Logica.Interfaces
{
    public interface IAlumnoLogica
    {
        Task<IEnumerable<Alumno>> GetAllAlumnos();
        Task<Alumno> GetAlumnoById(int id);
        Task<bool> RegisterAlumno(Alumno alumno);
        Task<bool> EditAlumno(Alumno alumno);
        Task<bool> RemoveAlumno(int id);
    }
}
