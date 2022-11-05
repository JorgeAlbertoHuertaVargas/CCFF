using CCFF.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Datos.Functions
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AplicationDbContext _context;
        public GenericRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                IEnumerable<T> entity= _context.Set<T>();

                return Task.FromResult(entity);
            }
            catch (Exception ex)
            {
                throw new DataException("Fallo al obtener datos", ex);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new DataException("Fallo al obtener por ID datos", ex);
            }
        }

        public async Task<bool> RegisterAsync(T entity)
        {
            try
            {
                _context.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Fallo al registrar datos", ex);
            }
        }

        public async Task<bool> EditAsync(T entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new DataException("Fallo al actualizar datos", ex);
            }
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                T? entity = await _context.Set<T>().FindAsync(id);
                _context.Remove(entity!);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw new DataException("Fallo al eliminar dato", ex);
            }
        }
           

    }
}
