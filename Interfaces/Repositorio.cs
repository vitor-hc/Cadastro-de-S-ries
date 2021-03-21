using System.Collections.Generic;
namespace Dio.Series.Interfaces
{
    public interface Repositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);

        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id,T entidade);
        int ProximoId();

         
    }
}