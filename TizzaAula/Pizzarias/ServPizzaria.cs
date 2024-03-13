using TizzaAula.Pizzarias.DTO;

namespace TizzaAula
{
    public interface IServPizzaria
    {
        void Inserir(Pizzaria pizzaria);
    }

    public class ServPizzaria : IServPizzaria
    {
        private DataContext _dataContext;

        public ServPizzaria(DataContext dataContext)
        {

            _dataContext = dataContext;

        }
        public void Inserir(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);

            _dataContext.SaveChanges();
        }
        
        public void Alterar(int id, AlterarPizzariaDTO alterarPizzariaDto)
        {
            var pizzaria = DataContext.Pizzaria.Where(p => p.Id == id).FirstOrDefault();
        }
        }
    }
}
