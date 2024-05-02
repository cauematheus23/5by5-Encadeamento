using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Encadeamento
{
    internal class Endereco
    {
        string cep;
        string localidade;
        string uf;
        string logradouro;
        string tipo_logradouro;
        string bairro;
        int numero;
        string complemento;

        public Endereco(string cep, string localidade, string uf, string logradouro, string tipo_logradouro, string bairro, int numero, string complemento)
        {
            this.cep = cep;
            this.localidade = localidade;
            this.uf = uf;
            this.logradouro = logradouro;
            this.tipo_logradouro = tipo_logradouro;
            this.bairro = bairro;
            this.numero = numero;
            this.complemento = complemento;
        }

        public override string? ToString()
        {
            if (complemento == "")
            {
                return "\nCEP:" + this.cep + "\nLocalidade: " + this.localidade + "\nUF: " + this.uf + "\nLogradouro: " + this.tipo_logradouro + " " + this.logradouro + "\nBairro: " + this.bairro + "\nNumero: " + this.numero;

            }
            else
            {
                return "\nCEP:" + this.cep + "\nLocalidade: " + this.localidade + "\nUF: " + this.uf + "\nLogradouro: " + this.tipo_logradouro + " " + this.logradouro + "\nBairro: " + this.bairro + "\nNumero: " + this.numero + "\nComplemento: " + this.complemento;
            }
            
        }
    }
}
