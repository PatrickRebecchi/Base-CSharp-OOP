using System;

namespace ConhecimentoCsharp.ClasseObjeto;

class Teste01
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seja bem-vindo");
        Console.WriteLine("Quer acessar o portal dos alunos?");
        Console.WriteLine("Digite s ou n");
        string resposta = Console.ReadLine();

        if (resposta == "s" || resposta == "S")
        {
            // Chama a função Nome e armazena o valor retornado
            string nome = Nome();

            Console.WriteLine("Qual a sua idade?");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
            {
                Console.WriteLine("Idade inválida. Digite um número positivo.");
            }

            if (idade <= 18)
            {
                // Passa o nome como parâmetro para VerificarEmail
                VerificarEmail(nome);
            }
            else
            {
                Console.WriteLine("Portal para menores de idade");
            }
        }
        else
        {
            Console.WriteLine("Tudo bem, até a próxima");
        }
    }

    // Função para obter o nome do usuário
    static string Nome()
    {
        Console.WriteLine("Digite seu primeiro nome: ");
        return Console.ReadLine();
    }

    // Função para verificar o email
    static void VerificarEmail(string nome)
    {
        string email;
        bool emailValido = false;

        while (!emailValido)
        {
            Console.WriteLine("Digite seu email de estudante");
            email = Console.ReadLine();

            if (email.Contains("@aluno.com.br"))
            {
                Console.WriteLine("Email válido");
                emailValido = true;
                // Passa o nome como parâmetro para VerificarSenha
                VerificarSenha(nome);
            }
            else
            {
                Console.WriteLine("Email inválido. Tente novamente.");
            }
        }
    }

    // Função para verificar a senha
    static void VerificarSenha(string nome)
    {
        Console.WriteLine("Digite a sua senha:");
        string senha = Console.ReadLine();

        if (senha == nome || senha == "1234")
        {
            Console.WriteLine("Ok, senha válida");
            Console.WriteLine("Vamos começar");
        }
        else
        {
            Console.WriteLine("Senha inválida. Tente novamente.");
            VerificarSenha(nome);  // Chama a função novamente
        }
    }
}
