using SnapsLibrary;


public class Car
{
    public void StartProgram()
    {
        SnapsEngine.DisplayImageFromUrl("https://st.hzcdn.com/simgs/1711fefa0603fedf_4-1809/industrial-novelty-signs.jpg"); // add background image of a diner sign
        SnapsEngine.SetTitleString("Car Counter");
        // variables that count the number of cars, vans, bikes, and trucks
        int car = 0;
        int van = 0;
        int bike = 0;
        int truck = 0;
        
        
        bool button = true;

        // loop that allows user to keep clicking on different transportations until user wants sum.
        while (button == true)
        {
            // stores what user selects from the 5 buttons
            string pick = SnapsEngine.SelectFrom5Buttons("Car", "Van", "Bike", "Truck", "Sum");
            // adds one to whichever user picks
            if (pick == "Car")
                car = car + 1;
            if (pick == "Van")
                van = van + 1;
            if (pick == "Bike")
                bike = bike + 1;
            if (pick == "Truck")
                truck = truck + 1;
            if (pick == "Sum")
            {
                // if user picks sum text is cleared and then program gives user the amount of times he/she clicked on each transportation.
                SnapsEngine.ClearTextDisplay();
                SnapsEngine.AddLineToTextDisplay("There were " + car.ToString() + " cars");
                SnapsEngine.Delay(10);
                SnapsEngine.AddLineToTextDisplay("There were " + van.ToString() + " vans");
                SnapsEngine.Delay(10);
                SnapsEngine.AddLineToTextDisplay("There were " + bike.ToString() + " bikes");
                SnapsEngine.Delay(10);
                SnapsEngine.AddLineToTextDisplay("There were " + truck.ToString() + " trucks");
                SnapsEngine.Delay(10);
                // ends the ability to select transportations.
                button = false;
            }
                {

                }
            }
        }
       

    }
        



