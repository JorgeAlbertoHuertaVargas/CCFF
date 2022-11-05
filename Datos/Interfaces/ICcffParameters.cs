using CCFF.Modelo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Datos.Interfaces
{
    public interface ICcffParameters
    {
        bool UpdateParametersSystem(int id, string value, bool state);
        bool UpdateStateParameter(int id, bool state);
        ParametersCcff GetParametersSystemById(int id);
        List<ParametersCcff> GetAllParametersSystem();
    }
}
