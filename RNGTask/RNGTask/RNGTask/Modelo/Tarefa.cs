using System;
using System.Collections.Generic;
using System.Text;

namespace RNGTask.Modelo
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Detalhe { get; set; }
        public DateTime DataEstimada { get; set; }
        public DateTime DataFinalizada { get; set; }
    }
}
