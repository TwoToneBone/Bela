using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int lines = int.Parse(inputs[0]) * 4;
            
            Dictionary<char, int> cardsDominant = new Dictionary<char, int>()

            {
                {'A',11 },
                {'K',4 },
                {'Q',3 },
                {'J',20 },
                {'T',10 },
                {'9',14 },
                {'8',0 },
                {'7',0 }
            };

            Dictionary<char, int> cards = new Dictionary<char, int>()
            {
                {'A',11 },
                {'K',4 },
                {'Q',3 },
                {'J',2 },
                {'T',10 },
                {'9',0 },
                {'8',0 },
                {'7',0 }

            };

            Dictionary<char, int> currentCard;
            int totalScore = 0;

            for (int i = 0; i < lines; i++)
            {
                string dealtCard = Console.ReadLine();

                if (inputs[1][0] == dealtCard[1])
                {
                    currentCard = cardsDominant;
                }
                else
                {
                    currentCard = cards;
                }

                totalScore += currentCard[dealtCard[0]];
            }

            Console.WriteLine(totalScore);

        }
    }
}
