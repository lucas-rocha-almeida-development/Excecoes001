using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            int resultado = n1 / n2;
            Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ) { 
                Console.WriteLine("Não e possivel dividir o valor por zero! ");
            
            }
            catch (FormatException)
            {//não sendo digitado um valor inteiro acima ( exception Format)
                Console.WriteLine("Você digitou um caractere não permito!!");
            }
            
            
            finally {
                Console.WriteLine();

                Console.WriteLine("Obrigado pela participação no teste!!");
            
            }
            Console.ReadKey();

        }
        
    }
}
