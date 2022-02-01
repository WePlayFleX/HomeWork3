using cs = System.Console;

class Dice
{
    public static bool GamerFirst(int aG, int bG, int aC, int bC)
    {
        int GamerSumm = aG + bG;
        cs.WriteLine(aG + "\t" + bG);
        cs.WriteLine("The sum of the player's points: " + GamerSumm);
        int CompSumm = aC + bC;
        cs.WriteLine(aC + "\t" + bC);
        cs.WriteLine("The sum of the computer points: " + CompSumm);
       
        if (GamerSumm > CompSumm)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CompFirst(int aC, int bC, int aG, int bG)
    {
        int CompSumm = aC + bC;
        cs.WriteLine(aC + "\t" + bC);
        cs.WriteLine("The sum of the computer points: " + CompSumm);
        int GamerSumm = aG + bG;
        cs.WriteLine(aG + "\t" + bG);
        cs.WriteLine("The sum of the player's points: " + GamerSumm);

        if (GamerSumm < CompSumm)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

