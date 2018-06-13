using SnapsLibrary;


public class VoiceOfPizza
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("What kind of pizza?!");
        // variables that count pizza types
        int pepperoni = 0;
        int cheese = 0;
        int beef = 0;
        int supreme = 0;
        // counter variable for loop
        int counter = 1;

        // loop around 4 times unless overview is clicked
        while (counter <= 4)
        {

            {
                // asks user to say favorite pizza or overview 
                string toppingChoice = SnapsEngine.SelectFromFiveSpokenPhrases(prompt: "What's your favorite pizza?", phrase1: "Pepperoni", phrase2: "Cheese", phrase3: "Supreme", phrase4: "Beef", phrase5: "Overview");
                // adds one to whatever pizza user chose
                if (toppingChoice == "Pepperoni")
                    pepperoni = pepperoni + 1;
                if (toppingChoice == "Cheese")
                    cheese = cheese + 1;
                if (toppingChoice == "Beef")
                    beef = beef + 1;
                if (toppingChoice == "Supreme")
                    supreme = supreme + 1;

                // if user selects overview, it will display and say what choices he/she chose
                if (toppingChoice == "Overview")
                {
                    SnapsEngine.ClearTextDisplay();
                    SnapsEngine.SpeakString("There were " + pepperoni + " pepperoni pizzas");
                    SnapsEngine.AddLineToTextDisplay("There were " + pepperoni + " pepperoni pizzas");
                    SnapsEngine.Delay(3);
                    SnapsEngine.SpeakString("There were " + cheese + " cheese pizzas");
                    SnapsEngine.AddLineToTextDisplay("There were " + cheese + " cheese pizzas");
                    SnapsEngine.Delay(3);
                    SnapsEngine.SpeakString("There were " + beef + " beef pizzas");
                    SnapsEngine.AddLineToTextDisplay("There were " + beef + " beef pizzas");
                    SnapsEngine.Delay(3);
                    SnapsEngine.SpeakString("There were " + supreme + " supreme pizzas");
                    SnapsEngine.AddLineToTextDisplay("There were " + supreme + " supreme pizzas");
                    SnapsEngine.Delay(3);
                    // exits loop
                    break;

                }
                // if no logical selection has been chosen, alerts users of error and repeats the prompt
                else
                {
                    SnapsEngine.SpeakString("Sorry that is not a viable selection!");
                    continue;
                }

           
                counter = counter + 1;
            }
        }    
       // if user says 4 pizza choices, this block runs. its an overview without clicking on it after max 4 choices
            SnapsEngine.ClearTextDisplay();
            SnapsEngine.SpeakString("There were " + pepperoni + " pepperoni pizzas");
            SnapsEngine.AddLineToTextDisplay("There were " + pepperoni + " pepperoni pizzas");
            SnapsEngine.Delay(3);
            SnapsEngine.SpeakString("There were " + cheese + " cheese pizzas");
            SnapsEngine.AddLineToTextDisplay("There were " + cheese + " cheese pizzas");
            SnapsEngine.Delay(3);
            SnapsEngine.SpeakString("There were " + beef + " beef pizzas");
            SnapsEngine.AddLineToTextDisplay("There were " + beef + " beef pizzas");
            SnapsEngine.Delay(3);
            SnapsEngine.SpeakString("There were " + supreme + " supreme pizzas");
            SnapsEngine.AddLineToTextDisplay("There were " + supreme + " supreme pizzas");
            SnapsEngine.Delay(3);



        }

        

    }
        



