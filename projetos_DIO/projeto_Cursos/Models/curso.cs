using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C#.projetos_DIO.projeto_Cursos.Models;
public class Curso{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public Curso(string nome, List<Pessoa> alunos){
        Nome = nome;
        Alunos = alunos;
    }

    public void AdcionarAluno(){

        Alunos.Add();
        Console.WriteLine($"Aluno {Nome} adicionado com sucesso!");

    }
    public void RemoverAluno(){

        Alunos.Remove();
        Console.WriteLine($"Aluno {Nome} Removido com sucesso!");

    }

    public int AlunosMatriculados(){

        int QntAlunos = Alunos.Count;

        return QntAlunos;

    }

    public void ListarAlunos(){

        Console.WriteLine("\t\t--------- Alunos ---------\n\n");

        foreach(Pessoa aluno in Alunos){

            Console.WriteLine({aluno.Nome});
        }
    
    }

}
