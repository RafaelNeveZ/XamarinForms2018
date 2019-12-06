using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace TaregaApp.Modelo
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> Lista { get; set; }
        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }
        public void Remover(int index)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);
            SalvarNoProperties(Lista);
        }
        public void Finalizar (int index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);
            tarefa.Quando = DateTime.Now;
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);

        }
        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        private void SalvarNoProperties(List<Tarefa> lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string jsonValue = JsonConvert.SerializeObject(Lista);
            App.Current.Properties.Add("Tarefas", jsonValue); //Shared pref
        }
        public List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                string JsonVal = (string)App.Current.Properties["Tarefas"];
                List<Tarefa> lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);
                return lista;
            }
            return new List<Tarefa>();
        }
    }
}
