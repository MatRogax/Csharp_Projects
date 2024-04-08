using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C#.projetos_DIO.projeto_Cursos.Models;

public class Pessoa{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public int Idade { get; set; }
    public string CPF { get;}
    public string NomeCompleto { get; set; }

    public Pessoa(string nome, string sobrenome, int idade){
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
        NomeCompleto = nome + " " + sobrenome;
    }

    public void CpfGenerator(){
        Random rnd = new Random();
        CPF = rnd.Next(10000000000, 99999999999).ToString();
    }


    public void MostrarDados(){

        Console.WriteLine($"Nome: {NomeCompleto}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"CPF: {CPF}");

    }

}
    

