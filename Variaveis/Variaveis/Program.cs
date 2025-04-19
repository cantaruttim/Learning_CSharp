using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        struct Pessoa
        {
            public string Nome;
            public int Idade;
            public double Altura;
            public double Peso;       
        }

        enum Notas
        {
            Minima = 10,
            Media = 20,
            Maxima = 30
        }

        static void Main(string[] args)
        {

            #region Structs

            Pessoa p1 = new Pessoa();
            p1.Nome = "Matheus";
            p1.Idade = 30;
            p1.Altura = 1.70;
            p1.Peso = 69.35;

            Console.WriteLine("\n");

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
            Console.WriteLine(p1.Altura);
            Console.WriteLine(p1.Peso);

            Console.WriteLine("\n");

            // OU
            Pessoa p2 = new Pessoa()
            {
                Nome = "Gabriella",
                Idade = 28,
                Altura = 1.65,
                Peso = 55
            };

            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Idade);
            Console.WriteLine(p2.Altura);
            Console.WriteLine(p2.Peso);

            #endregion

            #region Enumerações
            Notas notasAlunos = Notas.Maxima;
            //Console.WriteLine(notasAlunos);
            #endregion

            #region Constantes
            // número Pi
            const double pi = 3.1415;
            #endregion

            #region Object (System.Object) 
            /* base para todos os tipos. Consegue comportar qq tipo de dado
               Diferente do tipo Var   */
            object obj = "";
            #endregion

            #region Var - Tipo definido quando é inicializado
            // não temos certeza o tipo que a variável irá receber
            var valor = 140;
            //Console.WriteLine(valor);
            #endregion

            #region Strings
            string varS = "texto";
            //Console.WriteLine(varS);
            #endregion

            #region Boolean
            bool verificar = false;
            verificar = true;
            //Console.WriteLine(verificar);
            #endregion

            #region Caracteres
            char letra = 'a';
            char escape = '\0'; // \n, \0, \\
            char codigo = '\u0041';

            //Console.WriteLine(letra);
            //Console.WriteLine(escape);
            //Console.WriteLine(codigo);
            #endregion

            #region Ponto flutuante
            float real1 = 100.75f;
            float real2 = 100F;
            double real3 = 15.50;
            decimal real4 = 752358.57m;

            //Console.WriteLine(real4);
            #endregion

            #region Variáveis integrais
            //long numero = 1580;

            //Console.WriteLine("Número será de: " + numero);
            //Console.ReadKey();
            #endregion

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
