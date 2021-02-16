using System;

namespace dogfeedcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog Feed Calculator - Calculadora de Ração Para Cães");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Qual é o peso do seu cachorro?");
            int peso = int.Parse(Console.ReadLine());

            if (peso <= 3)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 200g por dia.");

            }
            else if (peso <= 5)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 250g por dia.");
            }
            else if (peso <= 7)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 300g por dia.");
            }
            else if (peso <= 10)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 350g por dia.");
            }
            else if (peso <= 15)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 550g por dia.");
            }
            else if (peso <= 20)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 700g por dia.");
            }
            else if (peso <= 25)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 950g por dia.");
            }
            else if (peso <= 30)
            {
                Console.WriteLine("Quantidade de ração ieal para seu cachorro é de 1kg por dia.");
            }
            else if (peso <= 35)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 1.2kg por dia.");
            }
            else if (peso <= 40)
            {
                Console.WriteLine("Quantidade de ração ideal para seu cachorro é de 1.3kg por dia.");
            }
            else
            {
                Console.WriteLine("Quantidade de ração ieal para seu cachorro é de +1.5kg por dia.");
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ATENÇÃO! A quantidade de comida vai depender muito do metabolismo e nível de atividade física do seu Pet, por esse motivo é importante ir sempre pesando ele e analisando a estrutura corporal e ajustar a quantidade caso necessário.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Fonte:www.animalnatural.com.br"); 
        }
    }
}


