using DesignPatterns.Interfaces;
using DesignPatterns.Structural.Adapter.Adapters;

namespace DesignPatterns.Structural.Adapter
{
    public class AdapterExample : IPatternExample
    {
        public static void Execute()
        {
            /*\
             ** Definição
             * Adapta uma interface em outra de acordo com a expectativa do cliente
             * Permite a colaboração de objetos com interfaces incompativeis
             * Também conhecido como Wrapper ou Invólucro
             *
             ** Intenção
             * Converter a interface de uma classe em outra
             * Envolver (Wrap) uma classe existente com uma nova interface
             * Introduzir um componente legado em um novo sistema
             *
             ** Elementos
             * Adaptee: Define uma interface existente que necessita ser adaptada
             * Target: Define a interface do domínio específico que o cliente usa
             * Client: Colabora com os objetos em conformidade com a interface target
             * Adapter: Adapta a interface adaptee para a interface da classe target
             *
             ** Adaptador de Objeto
             * Essa implementação usa o princípio de composição do objeto:
             * O adaptador implementa a iterface de um objeto e encobre o outro
             *
             ** Adaptador de Classe
             * Essa implementação usa a herança:
             * O adaptador herda interfaces de ambos os objetos ao mesmo tempo (Herança Múltipla)
             *
             ** Exemplos de uso
             * Quando um objeto precisa usar uma classe existente com uma interface imcompatível
             * Quando você deseja criar uma classe reutilizável que coopere com classes que não possuem interfaces compatóveis
             *
             ** Vantagens
             * Aumenta a reutilização do código
             * Você pode usar código entre plataformas diferentes
             * Permitem a interação de dois ou mais objetos incompatíveis
             *
             ** Desvantagens
             * A complexidade geral do código aumenta porque você precisa introduzir um conjunto de novas interfaces e classes
            \*/

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\nAdapter Example");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            string[,] studentsArray = new string[5, 4]
            {
                { "101", "Major", "", "1000" },
                { "102", "Henrique", "", "2000" },
                { "103", "Nelso", "", "3000" },
                { "104", "Claudete", "", "900" },
                { "105", "Cristiane", "", "850" }
            };

            StudentAdapter studentAdapter = new();
            studentAdapter.ProcessMonthlyPayment(studentsArray);
        }
    }
}
