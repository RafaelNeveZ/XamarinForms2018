using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace TaregaApp.Modelo
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public DateTime? Quando { get; set; }
        public byte Prioridade { get; set; }


    }
}
