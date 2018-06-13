using SnapsLibrary;

public class Guest
{
    public void StartProgram()
    {
        int number = SnapsEngine.ReadInteger("How many guests?"); // stores the number user enters for guest size.
        string[] guest = new string[number]; // array that holds storage of number of guests

        for (int i = 0; i < guest.Length; i++)
        {
          // loops the amount of guests.
            guest[i] = SnapsEngine.ReadString("Please enter your name."); // appends names user inputs to array.
            

        }

        for (int i = 0; i < guest.Length; i++)
        {
        // displays the guest's names. 
            SnapsEngine.DisplayString(guest[i]);
        }
    }

}

// C#
// Exercise in How to Code in C#
