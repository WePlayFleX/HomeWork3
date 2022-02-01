using System;
using cs = System.Console;
using cv = System.Convert;

namespace HomeWork3
{
    class HomeWork3
    {
        public static void Main(string[] args)
        {
            //Task1
            try
            {
                cs.WriteLine("Enter the age of the dragon: ");
                int dragonAge = cv.ToInt32(cs.ReadLine());

                if (dragonAge <= 0)
                {
                    throw new Exception("Inappropriate number! ");
                }


                int dragonH = Dragon.DragonHeads(dragonAge);
                int dragonE = Dragon.DragonEyes(dragonAge);

                cs.WriteLine("Number of dragon heads - " + dragonH);
                cs.WriteLine("Dragon Eyes - " + dragonE);
            }
            catch (Exception e)
            {
                cs.WriteLine($"Error: {e.Message}");
            }
            cs.ReadKey();
            cs.Clear();


            //Task2
            string msg = string.Empty;
            cs.WriteLine("Enter a letter of English: ");
            char letter = cv.ToChar(cs.ReadLine());

            bool result = Alphabet.CheckLetter(letter);
            msg = result ? "Vowel letter! " : "Consonant letter! ";

            cs.WriteLine(msg);

            cs.ReadKey();
            cs.Clear();


            //Task3
            cs.WriteLine("Hey. Let's play dice! ");
            cs.WriteLine("The winner is the one who has more than three throws! ");
            cs.WriteLine("Let's start? ");
            cs.ReadKey();

            cs.WriteLine("1 - you start ");
            cs.WriteLine("2 - computer starts ");
            char answer = cv.ToChar(cs.ReadLine());
           
            try
            {
                while (answer != '1' && answer != '2')
                {
                    throw new Exception("Enter again! ");
                }
            }
            catch (Exception d)
            {
                cs.WriteLine($"Error: {d.Message}");
            }

            Random rand = new Random();
            int aG = rand.Next(1, 7);
            int bG = rand.Next(1, 7);
            int aC = rand.Next(1, 7);
            int bC = rand.Next(1, 7);
           
            switch (answer)
            {
                case '1':
                    result = Dice.GamerFirst(aG, bG, aC, bC);
                    msg = result ? "Player wins! " : "Computer wins( ";
                    cs.WriteLine(msg);

                    break;
                case '2':
                    result = Dice.CompFirst(aC, bC, aG, bG);
                    msg = result ? "Computer wins( " : "Player wins! ";
                    cs.WriteLine(msg);

                    break;
            }
            cs.ReadKey();
            cs.Clear();


            //Task4
            int moodNumber = rand.Next(1, 80);
            Mood_Sensor.Mood(moodNumber);
            cs.ReadKey();
            cs.Clear();
        }
    }
}
