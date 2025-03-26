using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecimentoCsharp.Encapsulamento;

internal class Encapsulamento01
{
    public class Pessoa
    {
        private string nome; // Dados privados não podem ser acessados diretamente
        private int idade;
        private double altura;
        public string Nome  // Propriedades públicas para acessar os dados privados
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade // Propriedades públicas para acessar os dados privados
        {
            get { return idade; }   // Get é usado para retornar o valor da variável privada
            set { idade = value; } // Set é usado para atribuir um valor à variável privada
        }
        public double Altura // Propriedades públicas para acessar os dados privados
        {
            get { return altura; }
            set { altura = value; }
        }
    }

    public class banco
    {
        private double saldo;
        private string nome;
        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Name(string valor)
        {
            sobrenome = valor;
        }

        public void Sacar(double valor)
        {
            saldo -= valor;
        }
    }
    public class Program
    {
        /*public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();  // Criando um novo objeto da classe Pessoa
            pessoa.Nome = "João";
            pessoa.Idade = 20;
            pessoa.Altura = 1.80;
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
            Console.WriteLine("Altura: " + pessoa.Altura);
        }
        */
        public static void Main(string[] args)
        {
            banco conta = new banco(); // Criando um novo objeto da classe banco
            conta.Nome = "João"; // Atribuindo um valor à propriedade Nome
            conta.Name("Silva");
            conta.Depositar(1000); // Chamando o método Depositar
                                   
            /*
                Aqui não é possível atribuir um novo valor à propriedade saldo, pois ela é somente leitura
                mas é possível atribuir um novo valor à propriedade Nome, pois o get permitir que qualquer pessoa
                possa acessar o valor da propriedade Nome

                conta.Nome = "Maria"; // Atribuindo um novo valor à propriedade Nome

                conta.Saldo = 2000; ---  Erro: a propriedade Saldo é somente leitura
            */


            Console.WriteLine("Seja bem vindo " + conta.Nome);

            while (true) // Loop infinito
            {


                Console.WriteLine("Digite 1 para depositar ou 2 para sacar ou 3 para consultar o seu saldo ou se desaja sair digite o 0");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    Console.WriteLine("Digite o valor que deseja depositar:");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor); // Chamando o método Depositar
                    Console.WriteLine("Processando depósito...");
                    Thread.Sleep(2000); // Aguarda 2 segundos
                    Console.WriteLine("Depósito realizado com sucesso!");
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Digite o valor que deseja sacar");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Sacar(valor);
                    Console.WriteLine("atualizando saldo......");
                    Thread.Sleep(2000);
                    Console.WriteLine("saldo atualizado");

                }
                else if (resposta == 3)
                {
                    Console.WriteLine("Seu saldo atual é R$ " + conta.Saldo);
                }
                else if (resposta == 0)
                {
                    Console.WriteLine("Obrigado por usar nosso banco! Até mais.");
                    break; // Sai do loop
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

            }
        }
    }
}
