using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matematicos  # ok
            int num1 = 15;
            int num2 = 2;
            int resultado = (num1 + num2);

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            Console.ReadLine();

            #endregion

            #region Precedencia de Operadores  ok

            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double res = (num1 + num2) * (num3 / 3);

            //Console.WriteLine(res);
            //Console.ReadKey();

            #endregion

            #region Operadores de Incrementos   #ok
            //int num1 = 10;

            //num1 = num1 + 1;
            //num1++;
            //++num1;
            //num1--;

            //Console.WriteLine(num1--);
            //Console.WriteLine(num1);

            //Console.readkey();

            #endregion

            #region Operador de Concatenaçao  #ok


            //string nome = "Leidiane";
            //string sobreNome = "Mota";
            //string nomeCompleto = nome + sobreNome;

            //Console.WriteLine(nomeCompleto);
            //Console.ReadKey();

            #endregion

            #region Atribuiçoes #ok

            //int num1 = 13;


            // num1 = num1 + 20;
            // num1 +=20;
            // num1 -= 2;
            //num1 *= 3;
            //num1 /= 2;
            //num1 %= 2;

            //string nome = "Leidiane";
            //nome = "Mota";
            //Console.WriteLine(nome);
            //Console.ReadKey();

            #endregion

            #region Operadores de Igualdade #ok
            ////Aqui eu declarei uma variavel boleana com nome res onde atribui o resultado da igualdade para esta variavel 
            //// bool res = 100 == 50 * 2;
            ////bool res2 = (200 / 2) !=( 100 + 100);  // ! diferente ou igual


            ////Aqui atribui uma variavel do tipo string com nome de nnome que atribui o meu nome para dentro variavel
            //string nnome = "Leidiane";
            ////Aqui declarei uma variavel booleana que vai recebre na variavel res3 a atribuição da variavel nnome e comparar se ela e diferente ou igual a string nome 
            //bool res3 = nnome != "Leidiane";

            //Console.WriteLine(res3);
            //Console.ReadKey();

            #endregion

            #region Operacoes Relacionais #ok

            //// bool res = 100 < 50 * 65;
            //// bool res = 100 + 25 > 50 * 2;
            //// bool res = 100 + 45 <= 50 * 2;
            // // bool res = 75 >= 50;
            //Console.WriteLine(res);
            //Console.ReadKey();


            #endregion

            #region Operadores Logicos #ok

            //bool res1 = 100 > 50;
            //bool res2 = 56 == 34;

            ////Aqui é o operador e
            ////bool final = res1 && res2;

            ////Aqui é operador ou enquanto uma da condiçoes foram atendidas retornará verdadeiro
            //bool final2 = res1 || res2;



            //Console.WriteLine(final2);
            //Console.ReadKey();


            #endregion

        }

    }
}
