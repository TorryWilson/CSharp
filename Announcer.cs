using SnapsLibrary;

public class Announcer 
{
    public void StartProgram()
    {
        string name;
        SnapsEngine.SpeakString("Welcome");
        SnapsEngine.SetTitleString("Name one of the 5 most common names?");



        for (int i = 1; i <= 5;) 
        {
            name = SnapsEngine.ReadString("What is your name?");
            
            if (name == "Jim" || name == "John" || name == "Bob" || name == "William" || name == "Paul")
            {
                SnapsEngine.SpeakString("That is one!");
                SnapsEngine.Delay(.5);
                SnapsEngine.SpeakString("Good job" + name + "is one of the most common names for men");
              
                break;
            }
               else 
            {
                SnapsEngine.SpeakString("No thats not one!");
                i++;

            }

            
         
            
        }
    }
}


// using SnapsLibrary -- apart of the book "Begin to Code with C#"
// a big error in this program is that, if user enters the right name but is not case sensitive, it will treat it as if its not a right answer.
// EX: user enters jim instead of Jim, the announcer will annnounce "No thats not one!".
// will update with a better program to not be case sensitve.
