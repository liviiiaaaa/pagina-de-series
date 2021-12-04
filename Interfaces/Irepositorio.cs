using System.Collections.Generic;

namespace PaginaDeSeries.Interfaces
{
    public interface Irepositorio<T> //quem inrá interpretar essa interface poderá passar esse T (que é um tipo genérico)
    {
        List<T> Lista(); //Método chamado lista que retorna uma lista de T

        T RetornaPorId(int id); // Passa um Id por parâmetro e ele retorna um T por parâmetro 

        void Insere (T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId(); 
    }
}