using PatternsInAction.Comportamiento;
using PatternsInAction.Construccion;
using PatternsInAction.Estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using PatternsInAction.Master;


namespace PatternsInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            var pattern = PatternMenu();

            while (pattern != "0")
            {
                switch (pattern)
                {
                    case "1": ExecutePattern(AbstractFactory.Show); break;
                    case "2": ExecutePattern(Builder.Show); break;
                    case "3": ExecutePattern(FactoryMethod.Show); break;
                    case "4": ExecutePattern(Prototype.Show); break;
                    case "5": ExecutePattern(Singleton.Show); break;
                    case "6": ExecutePattern(Adapter.Show); break;
                    case "7": ExecutePattern(Bridge.Show); break;
                    case "8": ExecutePattern(Composite.Show); break;
                    case "9": ExecutePattern(Decorator.Show); break;
                    case "10": ExecutePattern(Facade.Show); break;
                    case "11": ExecutePattern(Flyweight.Show); break;
                    case "12": ExecutePattern(Proxy.Show); break;
                    case "13": //ExecutePattern(() => ChainOfResponsability()); break;
                    case "14": ExecutePattern(Interpreter.Show); break;
                    case "15": ExecutePattern(Iterator.Show); break;
                    case "16": ExecutePattern(Mediator.Show); break;
                    case "17": //ExecutePattern(() => Command()); break;
                    case "18": ExecutePattern(Memento.Show); break;
                    case "19": ExecutePattern(Observer.Show); break;
                    case "20": ExecutePattern(State.Show); break;
                    case "21": ExecutePattern(Strategy.Show); break;
                    case "22": ExecutePattern(TemplateMethod.Show); break;
                    case "23": ExecutePattern(Visitor.Show); break;
                    default: Environment.Exit(0); break;
                }

                pattern = PatternMenu();
            }
        }


        private static void ExecutePattern(Action function)
        {
            Console.Clear();
            function.Invoke();
            Console.ReadLine();
        }

        private static void ExecuteAction(Action function)
        {
            function.Invoke();
        }

        public static string PatternMenu()
        {
            Console.Clear();
            foreach (var item in Service.GetTitlePatternType())
            {
                Console.WriteLine("");
                Console.WriteLine(item.Value);
                Console.WriteLine("");

                ExecuteAction(Service.GetActionPatternType(item.Key).Value);
            }

            Console.WriteLine("0.Exit");
            Console.WriteLine("");
            Console.WriteLine("Select a Pattern Number:");

            var pattern = Console.ReadLine();
            return pattern;
        }

    }
}
