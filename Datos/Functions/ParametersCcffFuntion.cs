using CCFF.Datos.Interfaces;
using CCFF.Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Datos.Functions
{
    public class ParametersCcffFuntion:ICcffParameters
    {
        public bool UpdateStateParameter(int id, bool state)
        {
            bool confirmar = false;
            try
            {
                using (var context = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
                {
                    var result = context.ParametersCcffs.SingleOrDefault(p => p.Id == id);

                    if (result != null)
                    {
                        result.State = state;
                        context.SaveChanges();
                        confirmar = true;
                    }
                }
            }
            catch (Exception error)
            {
                throw new DataException("Failed to insert data.", error);
            }
            return confirmar;
        }

        public bool UpdateParametersSystem(int id, string value, bool state)
        {
            bool confirmar = true;
            try
            {
                using (var context = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
                {
                    var result = context.ParametersCcffs.SingleOrDefault(p => p.Id == id);
                    if (result != null)
                    {
                        result.Value = value;
                        result.State = state;
                        context.SaveChanges();
                    }
                    else
                    {
                        confirmar = false;
                    }
                }
            }
            catch (Exception error)
            {
                throw new DataException("Failed to insert data.", error);
            }
            return confirmar;
        }

        public ParametersCcff GetParametersSystemById(int id)
        {
            ParametersCcff NewParameter = new ParametersCcff();
            try
            {
                using (var context = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
                {
                    var result = context.ParametersCcffs.SingleOrDefault(p => p.Id == id);
                    if (result != null)
                    {
                        NewParameter.Id = result.Id;
                        NewParameter.Type = result.Type;
                        NewParameter.Value = result.Value;
                        NewParameter.State = result.State;
                    }
                }
            }
            catch (Exception error)
            {
                throw new DataException("Failed to insert data.", error);
            }
            return NewParameter;
        }


        public List<ParametersCcff> GetAllParametersSystem()
        {
            List<ParametersCcff> parameters = new List<ParametersCcff>();
            try
            {
                using (var context = new AplicationDbContext(AplicationDbContext.ops.dbOptions))
                {
                    parameters = context.ParametersCcffs.ToList();
                }
            }
            catch (Exception error)
            {
                throw new DataException("Failed to insert data.", error);
            }
            return parameters;
        }
    }
}
