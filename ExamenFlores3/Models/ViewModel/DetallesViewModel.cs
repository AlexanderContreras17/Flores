using ExamenFlores3.Models.Entities;

namespace ExamenFlores3.Models.ViewModel
{
    public class DetallesViewModel
    {

        public Datos Dato { get; set; } = null!;
        public IEnumerable<IndexViewModel>Flores { get; set; } = null!;



    }
}
