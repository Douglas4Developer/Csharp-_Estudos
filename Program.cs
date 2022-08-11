using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////Estudos em C sharp//////////////////////////////////
            int umNumeroQualquer = 100;
            String umaStringQualquer = "Programar é muito bom!$";
            char [] charArr = new char[umNumeroQualquer];
            var MinhaString = "Douglas é um bom desenvolvedor";
            ///////////////////Fim declarações de variaveis///////////////////////////
            Console.WriteLine("Testando Variaveis em C#");
            Console.WriteLine(umaStringQualquer);
            Console.WriteLine(umNumeroQualquer);

            for (int i = 0; i < 10 ; i++) {Console.WriteLine("Deus é meu salvador");}


            Console.WriteLine("Variavel dinamica no CSharp, lembrando que o C# é uma linguagem fortemente tipada!");
            dynamic variaveldinamica = "azul";
            Console.WriteLine(variaveldinamica);
            variaveldinamica = 2;
            Console.WriteLine(variaveldinamica);
            variaveldinamica = 2.5f;
            Console.WriteLine(variaveldinamica);
            Console.WriteLine("Hello World!");
            Console.WriteLine(MinhaString);
            Console.WriteLine(MinhaString);
            Console.WriteLine(MinhaString);
            Console.ReadLine();
        }
    }
}
