using C.projetos_DIO.projeto_Cursos.Models;

string Nome = Console.ReadLine();
string Sobrenome = Console.ReadLine();
int Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("(1)-Inglês \n  (2)-Matemática\n (3)-Espanhol\n (4)-");

List <string> cursos = ["ingles","espanhol", "portugues","mandarim","frances"];

Pessoa pessoa1 = new Pessoa(Nome,Sobrenome,Idade);
Curso curso1 = new Curso()






