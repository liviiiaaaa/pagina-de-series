using System;
using System.Collections.Generic;
using PaginaDeSeries.Interfaces;
using System.Linq;

namespace PaginaDeSeries
{
    public class SerieRepositorio : Irepositorio<SeriesDeTv>
    {
        private readonly List<SeriesDeTv> ListaSerie;
        public SerieRepositorio()
        {
            ListaSerie = new List<SeriesDeTv>();
        }
        
        public void Atualiza(int id, SeriesDeTv objeto)
        {      
            ListaSerie[id] = objeto; //Método de atualizar série. Vai receber o objeto e irá colocá-lo na lista do vetor 
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(SeriesDeTv objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<SeriesDeTv> Lista()
        {
            return ListaSerie; //espera que retorne uma lista de séries 
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public SeriesDeTv RetornaPorId(int id)
        {
            return ListaSerie.FirstOrDefault(x => x.Id == id);//listaSerie[id];
        }
    }
}
