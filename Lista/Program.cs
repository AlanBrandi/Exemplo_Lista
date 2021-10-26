using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando lista.
            List<string> list = new List<string>();
            //Adicionando contéudo na lista.
            list.Add("Fabio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");

            //Adicionando um elemento em um local específico. 
            list.Insert(2, "Lucas");

            //Looping para a leitura da lista.
            foreach (string obj in list)
            {
                //Demonstrando quantos itens a lista possui.
                Console.WriteLine("Qauntidade de elementos na lista: " + list.Count);
                //Encontrando o primeiro elemento que começa com a letra A + demonstrando.
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Encontrando o ultimo elemento que começa com a letra A.
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Último elemento que começa com a letra A: " + s2);
            }

            //Buscando elemento pela posição.
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição de A: " + pos2);


            //Buscar todos os elementos com tamanho igual a 5 caracteres.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------");
            //Demonstrando os elementos.
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Removendo elementos da lista
            list.Remove("Andre");
            Console.WriteLine("--------------------------------------");
            //Demonstrando os elementos.
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover determinando um elementos da lista.
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("--------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover um elemento de determinada posição da lista.
            list.RemoveAt(3);
            Console.WriteLine("--------------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista a partir de uma posição e quantos elementos.
            list.RemoveRange(1, 2);
            Console.WriteLine("--------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
