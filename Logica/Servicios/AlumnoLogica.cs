using CCFF.Datos.Interfaces;
using CCFF.Modelo;
using CCFFF.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFFF.Logica.Servicios
{
    public class AlumnoLogica : IAlumnoLogica
    {
        private readonly IGenericRepository<Alumno> _alumnoRepository;
        public AlumnoLogica(IGenericRepository<Alumno> alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        public async Task<IEnumerable<Alumno>> GetAllAlumnos()
        {
            return await _alumnoRepository.GetAllAsync();
        }

        public async Task<Alumno> GetAlumnoById(int id)
        {
            return await _alumnoRepository.GetByIdAsync(id);

        }

        public async Task<bool> RegisterAlumno(Alumno alumno)
        {
            return await _alumnoRepository.RegisterAsync(alumno);
        }

        public async Task<bool> EditAlumno(Alumno alumno)
        {
            return await _alumnoRepository.EditAsync(alumno);
        }

        public async Task<bool> RemoveAlumno(int id)
        {
            return await _alumnoRepository.RemoveAsync(id);
        }
    }
}
