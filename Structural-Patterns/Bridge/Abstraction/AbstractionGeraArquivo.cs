using Bridge.Domain;
using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public class AbstractionGeraArquivo
    {
        protected IGeraArquivo _implementor;

        public AbstractionGeraArquivo(IGeraArquivo implementor)
        {
            _implementor = implementor;
        }

        public virtual void GravarArquivo(Funcionario funcionario)
        {
            _implementor.GravarArquivo(funcionario);
        }
    }
}