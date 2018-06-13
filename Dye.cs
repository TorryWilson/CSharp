using SnapsLibrary;

public class Randomness
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Special message if you score on a dice roll within 3 tries.");
        SnapsEngine.Delay(3);
        SnapsEngine.DisplayString("6");
        int diceRoll = SnapsEngine.ThrowDice();

    
        for (int count = 0; count < 4; count++)
        {

            if (diceRoll == 6)
            {
                SnapsEngine.DisplayString(diceRoll.ToString());
                SnapsEngine.Delay(.5);
                SnapsEngine.SpeakString("Congratulations! You won the message!");
                SnapsEngine.Delay(2);
                SnapsEngine.SpeakString("The message is....");
                SnapsEngine.Delay(3);
                SnapsEngine.SpeakString("I don't really have a special message");
                break;
            }
            else
            {
                SnapsEngine.DisplayString(diceRoll.ToString());
                SnapsEngine.SpeakString(diceRoll.ToString());
                SnapsEngine.Delay(1);
                SnapsEngine.SpeakString("Nope not getting the message");
                SnapsEngine.Delay(1);
                count++;
                
                
                if (count < 4)
                {
                    SnapsEngine.SpeakString("Next dye roll");
                    diceRoll = SnapsEngine.ThrowDice();
                 
                }
                else
                {
                    SnapsEngine.SpeakString("You suck ");
                    
                }

            }
        }
    }
}

// not correct yet.
// dont know why its not functioning properly but seems like an easy fix.
