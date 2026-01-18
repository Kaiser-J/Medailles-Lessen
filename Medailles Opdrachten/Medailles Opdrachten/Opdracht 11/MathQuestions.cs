using System;

class MathProblem
{
    private int number1;
    private int number2;
    private char operation;

    public MathProblem(int n1, int n2, char op)
    {
        number1 = n1;
        number2 = n2;
        operation = op;
    }

    public string GetQuestion()
    {
        return number1 + " " + operation + " " + number2 + " = ?";
    }

    public bool CheckAnswer(int userAnswer)
    {
        int correctAnswer = 0;

        // Kijkt wat voor som het is en berekent als het, het juiste antwoord is.

        if (operation == '+')
            correctAnswer = number1 + number2;
        else if (operation == '-')
            correctAnswer = number1 - number2;
        else if (operation == '*')
            correctAnswer = number1 * number2;
        else if (operation == '/')
            correctAnswer = number1 / number2;

        return userAnswer == correctAnswer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int score = 0;

        // Mogelijke Sommen.
        char[] operations = { '+', '-', '*', '/' };

        for (int i = 0; i < 5; i++)
        {
            char op = operations[rng.Next(operations.Length)];
            int a = rng.Next(1, 11);
            int b = rng.Next(1, 11);

            // Zorg dat delen altijd netjes uitkomt
            if (op == '/')
            {

                // We maken het dat a altijd een veelvoud is van b
                b = rng.Next(1, 11);
                a = b * rng.Next(1, 11);
            }

            // Nieuwe som maken
            MathProblem problem = new MathProblem(a, b, op);

            Console.WriteLine(problem.GetQuestion());

            // Antwoord van de gebruiker krijgen
            int userAnswer;
            bool validInput = int.TryParse(Console.ReadLine(), out userAnswer);

            if (!validInput)
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            if (problem.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Final score: " + score + "/5");

        if (score == 5)
            Console.WriteLine("Amazing!");
        else if (score >= 3)
            Console.WriteLine("Good job!");
        else
            Console.WriteLine("Keep practicing!");
    }
}
