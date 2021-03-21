using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;
namespace Dio.Series
{
    public class SerieRepositorio : Repositorio<Serie>
    {
        private List<Serie> listaSerie=new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
           listaSerie[id]=objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            //Pode implementar o envio de E-mail aqui.
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}