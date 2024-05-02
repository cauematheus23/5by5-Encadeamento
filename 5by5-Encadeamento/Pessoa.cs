using _5by5_Encadeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Pessoa
{
    string nome;
    int idade;
    Endereco endereco;

    public Pessoa(string nome, int idade, Endereco endereco)
    {
        this.nome = nome;
        this.idade = idade;
        this.endereco = endereco;
    }

    public override string? ToString()
    {
        return "Nome: " + this.nome + "\nIdade: " + this.idade + "\n========================\nENDEREÇO " + this.endereco.ToString();
    }
}

