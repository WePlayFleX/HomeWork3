using cs = System.Console;

class Mood_Sensor
{
    public static void Mood(int moodNumber)
    {
        if (moodNumber >= 1 && moodNumber <= 9)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood -  (͡° ͜ʖ ͡°)");
        }
        else if (moodNumber >= 10 && moodNumber <= 19)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - (>^.^)>");
        }
        else if (moodNumber >= 20 && moodNumber <= 29)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - (^*o*)^");
        }
        else if (moodNumber >= 30 && moodNumber <= 39)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - (ಥ﹏ಥ)");
        }
        else if (moodNumber >= 40 && moodNumber <= 49)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - ᕦ(ò_óˇ)ᕤ");
        }
        else if (moodNumber >= 50 && moodNumber <= 59)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - (¬‿¬)");
        }
        else if (moodNumber >= 60 && moodNumber <= 69)
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - (｡◕‿‿◕｡)");
        }
        else
        {
            cs.WriteLine("Mood number: " + moodNumber + "\tMood - ٩(ˊ〇ˋ*)و");
        }

    }
}

