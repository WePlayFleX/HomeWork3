class Dragon
{
    public static int DragonHeads(int age)
    {
        if (age <= 200)
        {
            return age * 3;
        }
        else if (age >= 201 && age <= 300)
        {
            return (age - 200) * 2 + 600;
        }
        else
        {
            return (age - 300) + 800;
        }
    }

    public static int DragonEyes(int age)
    {
        if (age <= 200)
        {
            return age * 6;
        }
        else if (age >= 201 && age <= 300)
        {
            return (age - 200) * 4 + 1200;
        }
        else
        {
            return (age - 300) * 2 + 1600;
        }
    }

}

