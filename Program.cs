using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculadora de dois digitos");
           //writeline pula uma linha para escrever
            Console.WriteLine("Por favor digite o primeiro digito");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ok, qual operação deseja fazer ?");
            Console.WriteLine("digite 1 para somar");
            Console.WriteLine("digite 2 para subtrair");
            Console.WriteLine("digite 3 para dividir");
            Console.WriteLine("digite 4 para multiplicar");
             int resposta = int.Parse(Console.ReadLine());
            
            double resultado = 0;
            bool validacao = true;
            //bool pode ser true ou false
            
                if (resposta == 1){
                    resultado = num1 + num2;
                }else if(resposta ==2){
                    resultado = num1 - num2;
                }else if(resposta ==3){
                    resultado = num1 / num2;
                }else if(resposta ==4){
                    resultado = num1 * num2;
                }else{
                    Console.WriteLine("o numero está incorreto");
                    validacao = false;  
                }
                if(validacao == true){
                     Console.WriteLine("o resultado = "+resultado);
                }
        }
    }
}
