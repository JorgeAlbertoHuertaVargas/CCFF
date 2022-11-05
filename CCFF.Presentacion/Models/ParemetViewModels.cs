using CCFF.Modelo.Entities;

namespace CCFF.Presentacion.Models
{
    public class ParemetViewModels
    {

        public int ParemetId { get; set; }
        public string ParemetName { get; set; }
        public bool Status { get; set; }

        public ParametersCcff Paremet { get; set; }
        public List<ParametersCcff> ParemetList { get; set; }

    }
}
