﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1.Serviços.Modelo;
using Newtonsoft.Json;
namespace App1.Serviços
{
    class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            if (end.cep == null) return null;

            return end;

        }

    }
}
