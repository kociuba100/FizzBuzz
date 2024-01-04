using System.Reflection.Metadata.Ecma335;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            //user wprowadza liczbę
            Console.WriteLine("Jesteś w grze FizzBuzz.\n Fizz za 3-ke,\n Buzz za 5-tkę,\n FizzBuzz za 3-kę z 5-tką.\n\n Podaj liczbę, aby zacząć rozdanie: ");
            var numberUser = GetNumber();
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.FizzBuzzMethod(numberUser);
        }
        static int GetNumber()
        {
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałes złą wartość, wpisz ponownie");
                    continue;
                }
                return number;
            }
            
        }
    }
}
