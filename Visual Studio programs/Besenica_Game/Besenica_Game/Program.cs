using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write(" Enter word: ");

            word = Console.ReadLine();
            Console.Clear();

            string wordToGuess = word;
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (i == 0 || i == (wordToGuess.Length) - 1)
                {
                    displayToPlayer.Append(wordToGuess[i]);
                }

                else if (wordToGuess[i] == wordToGuess[0] || wordToGuess[i] == wordToGuess[(wordToGuess.Length) - 1])
                {
                    displayToPlayer.Append(wordToGuess[i]);
                }

                else displayToPlayer.Append('+');
            }

            int symb = 0;
            for(int i = 0; i < wordToGuess.Length; i++)
            {
                if (displayToPlayer[i] != '+') symb++;
            }

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 5;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char guess;

            Console.WriteLine(displayToPlayer.ToString());

            while (!won && lives > 0)
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            lettersRevealed++;

                        }
                    }

                    if (lettersRevealed == (wordToGuess.Length) - symb)
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                    lives--;
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", wordToGuess);
        }
    }
}