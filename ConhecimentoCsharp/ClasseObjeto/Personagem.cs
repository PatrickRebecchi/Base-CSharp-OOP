using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecimentoCsharp.ClasseObjeto;
// Classe Personagem
public class Personagem
{
    // Usando propriedades para encapsular os campos
    public string Nome { get; private set; }
    public int Forca { get; private set; }
    public int Altura { get; private set; }
    public string Raca { get; private set; }
    public int Peso { get; private set; }

    // Construtor para inicializar um personagem com valores
    public Personagem(string nome, int altura, int forca)
    {
        Nome = nome;
        Altura = altura;
        Forca = forca;
    }

    // Método para exibir as informações do personagem
    public void Mostrar()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine("----------------------");
    }
}

// Classe principal (Program)
public class Program
{
    public static void Main(string[] args)
    {
        // Instanciando objetos com o construtor
        Personagem naruto = new Personagem("Naruto", 160, 120); // Criando um novo objeto da classe Personagem
        Personagem goku = new Personagem("Goku", 180, 140);

        // Exibindo os dados dos personagens
        naruto.Mostrar(); // Exibindo os dados do personagem 
        goku.Mostrar();
    }
}