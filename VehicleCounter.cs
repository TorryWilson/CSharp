// using SnapsEngine from How to Code C#

// A neighbor of yours wants to open a diner for truck drivers. He is doing research on the traffic in the area because he wants to know how many trucks pass his site each day. He wants a way of counting cars, vans, trucks, and bikes as they go past, and wants to simply press a button for each different kind of vehicle that he sees go by.

// Write a program that will do this for him.using

 SnapsLibrary;

public class Vehicle             
{
    public void StartProgram()
    {

        SnapsEngine.SetTitleString("How many vehicles passed?");

        bool go = true;
        string picker;
        int bikeCounter = 0;
        int carCounter = 0;
        int truckCounter = 0;
        int vanCounter = 0;

       

        while (go)
        {
            picker = SnapsEngine.SelectFrom5Buttons("Car", "Bike", "Van", "Truck", "Total");
            if (picker == "Bike")
            {
                
                bikeCounter = bikeCounter + 1;

            }

            if (picker == "Car")
            {
                carCounter = carCounter + 1;
            }

            if (picker == "Van")
            {
                vanCounter = vanCounter + 1;
            }

            if (picker == "Truck")
            {
                
                 truckCounter = truckCounter + 1;
            }

            if (picker == "Total")
            {
                go = false;
                SnapsEngine.ClearTextDisplay();
                string van = vanCounter.ToString();
                string bike = bikeCounter.ToString();
                string truck = truckCounter.ToString();
                string car = carCounter.ToString();

                SnapsEngine.DisplayString("There was" + " " + van + " " + "van(s)");
                SnapsEngine.Delay(3); 
                SnapsEngine.DisplayString("There was" + " " + bike + " " + "bike(s)");
                SnapsEngine.Delay(3);
                SnapsEngine.DisplayString("There was" + " " + truck + " " + "truck(s)");
                SnapsEngine.Delay(3);
                SnapsEngine.DisplayString("There was" + " " + car + " " + "car(s)");
                SnapsEngine.Delay(4);
                int sum = vanCounter + bikeCounter + truckCounter + carCounter;
                string summer = sum.ToString();
                SnapsEngine.SpeakString("There was a total of" + summer + "vehicles");
                SnapsEngine.DisplayString("There was a total of" + " " + summer + " " + "vehicles");


            }
        }
        

        }
    }

// using SnapsEngine from How to Code C#
// A neighbor of yours wants to open a diner for truck drivers. He is doing research on the traffic in the area because he wants to know how many trucks pass his site each day. He wants a way of counting cars, vans, trucks, and bikes as they go past, and wants to simply press a button for each different kind of vehicle that he sees go by. 
// Write a problem that will do this for him.


