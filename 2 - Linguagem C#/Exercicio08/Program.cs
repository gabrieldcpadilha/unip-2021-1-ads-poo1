using System;
using System.Collections.Generic;

namespace Exercicio08
{
    class Program
    {
        public static void Main(string[] args)
        {
            TesteAula19Marco();
        }

        private static void TesteAula19Marco() 
        {
            Agencia agenciaAraraquara = new Agencia();
            agenciaAraraquara.Numero = 1;

            // Criar o primeiro Cliente com sua respectiva Conta (e Agencia)
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Gabriel";
            cliente1.Documento = "111.111.111-11";
            // Exemplo de criação de variavel auxiliar para relacionar a Conta
            Conta contaCliente1 = new Conta();
            contaCliente1.Numero = "00001-0";
            contaCliente1.Agencia = agenciaAraraquara;
            cliente1.Conta = contaCliente1;

            // Criar o segundo Cliente com sua respectiva Conta (e Agencia)
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Padilha";
            cliente2.Documento = "222.222.222-22";
            // Exemplo sem a criação de variavel auxiliar para relacionar a Conta
            cliente2.Conta = new Conta();
            cliente2.Conta.Numero = "00002-0";
            cliente2.Conta.Agencia = agenciaAraraquara;

            // Executar métodos de depósito e saque para ambos Clientes
            cliente1.Depositar(1000);
            cliente1.Sacar(150);
            cliente1.Sacar(200);

            cliente2.Depositar(500);
            cliente2.Sacar(100);
            cliente2.Sacar(100);
            cliente2.Sacar(100);
            cliente2.Sacar(100);
            cliente2.Sacar(100);
            cliente2.Sacar(100); // Saldo Insuficiente

            // Executar métodos de transferência entre ambos Clientes
            cliente1.Transferir(1000, cliente2.Conta); // Saldo insuficiente

            // Imprimir o extrato de ambos Clientes
            cliente1.ImprimirExtrato();
            cliente2.ImprimirExtrato();
        }

        private static void TesteAula12Marco() 
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Gabriel Padilha";
            cliente.Documento = "123456789-0";

            // Criar uma Conta com Agência e relacioná-la com o Cliente
            Conta contaCorrente = new Conta();
            contaCorrente.Numero = "00001-0";
            contaCorrente.Limite = 500;

            Agencia agenciaDigital = new Agencia();
            agenciaDigital.Numero = 1;

            contaCorrente.Agencia = agenciaDigital;

            cliente.Conta = contaCorrente;

            // Criar 2 Cartões e relacioná-los com o Cliente
            Cartao cartaoCredito = new Cartao();
            cartaoCredito.Numero = 111;

            Cartao cartaoDebito = new Cartao();
            cartaoDebito.Numero = 222;

            cliente.Cartoes = new List<Cartao>();
            cliente.Cartoes.Add(cartaoCredito);
            cliente.Cartoes.Add(cartaoDebito);

            Console.WriteLine("Nome: {0} ({1})", cliente.Nome, cliente.Documento);
            Console.WriteLine("Número Conta: {0}", cliente.Conta.Numero);
            Console.WriteLine("Agência: {0}", cliente.Conta.Agencia.Numero);
            Console.WriteLine("Lista de Cartões:");
            
            // Criar contador auxiliar para numerar o Cartão dentro do foreach
            short Contcart;
            Contcart = 1;

            foreach (Cartao cartao in cliente.Cartoes)
            {
                Console.WriteLine("Cartão {0}: {1}", Contcart,cartao.Numero);
                Contcart++;
            }
        }
    }
}
