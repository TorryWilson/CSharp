using SnapsLibrary;


public class Compare
{

    int Limit(string prompt, int min, int max)
    {
        int result;

        do
        {
            result = SnapsEngine.ReadInteger(prompt);
        } while (result < min || result > max);

        return result;
    }

    public void StartProgram()
    {
        int age = Limit(prompt: "Whats your age in years?", min:0, max:100);
        SnapsEngine.DisplayString((age.ToString()));

    }
        
}


