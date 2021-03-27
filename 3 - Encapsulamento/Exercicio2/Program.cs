/**
Imagine que uma empresa está interessada em cadastrar seus prestadores de serviços.
Tais prestadores podem ser PF ou PJ, com as seguintes informações (relevantes no domínio em questão):

Pessoa Física (PF):
Nome
CPF
Data de Nascimento
Email
Telefone
CEP
Logradouro
Complemento

Pessoa Jurídica (PJ):
Razão Social
CNPJ
Email
Telefone
CEP
Logradouro
Complemento
**/

using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Gabriel";
            pf.Email = "gdcpadilha@outlook.com";

            Console.WriteLine(pf.Nome);
        }
    }
}
