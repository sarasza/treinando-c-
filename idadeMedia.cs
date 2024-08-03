// Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a
// idade média entre essas pessoas, com uma casa decimal.

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            double media;

            string[] vet1 = Console.ReadLine().Split(' ');
            string name1 = vet1[0];
            int age1 = int.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            string name2 = vet2[0];
            int age2 = int.Parse(vet2[1]);

            media = (age1 + age2) / 2.0;

            Console.WriteLine((" A idade média de " + name1 + " e " + name2 + " é de " + media.ToString("F1") +" anos "), CultureInfo.InvariantCulture);
        }
    }
}
