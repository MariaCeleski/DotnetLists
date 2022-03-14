using System.Diagnostics;
using System.Collections.Generic;
using System;
using static DotnetLists.Program;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //var meuArray = new int[5];
            // var meuArray = new int[5]{1,2,3,4,5}; somente 5 posições que é = a [5]
            // var meuArray = new bool[5]{false, true, false}; 
            // var meuArray = new string[5]{"1","2","3","4","5"}; 

            //var meuArray = new int[5] { 10, 21, 31, 43, 54 };
            //var meuArray = new Teste[2];
            //meuArray[0] = new Teste();
            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);
            // Console.WriteLine(meuArray[4]);

            // var meuArray = new int[5] { 10, 21, 31, 43, 54 };
            // meuArray[0] = 12;

            // Console.WriteLine(meuArray.Length);


            // for (var index = 0; index <= meuArray.Length; index++)
            // {
            //     Console.WriteLine(meuArray[index]);
            // }

            var funcionarios = new Funcionario[1];
            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Andre", Cpf = "859.235.693-00", Idade = 41, Cargo = "Desenvolvedor" };

            foreach (var funcionario in funcionarios)

            {
                Console.WriteLine("Id = " + funcionario.Id);
                Console.WriteLine("Nome = " + funcionario.Nome);
                Console.WriteLine("CPF = " + funcionario.Cpf);
                Console.WriteLine("Idade = " + funcionario.Idade);
                Console.WriteLine("Cargo = " + funcionario.Cargo);

            }

        }

    }

    // foreach (var item in meuArray)
    // {
    //     Console.WriteLine(item);
    // }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }

    }

}

