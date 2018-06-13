using SnapsLibrary;

class ContactBook
{
    // this method is used to standardize whats read from user
    string prettyInput(string input)
    {
        input = input.Trim();
        // if whitespace between word, this method deletes whitespace. Ex: If user presses space bar before starting name
        input = input.ToLower();
        // if user enters a name, it is not case sensitive. Ex: Torry = torry = tOrry = TORRY etc etc.
        return input;
        // returns the standardize read variable
    }

    bool FetchContact(string name, out string address, out string phone)
        // method that returns true or false
    {
        name = prettyInput(name);
        // uses prettyInput method to standardize whats read

         address = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":address");
        // retrieves whats stored in the address space corresponding with the contact's name you're looking for

        phone = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":phone");
        // retrieves whats stored in the phone space corresponding with the contact's name you're looking for

        if (address == null || phone == null) return false;
        // if the name you're searching for is not in the contact book return false
        // does this because if the address or phone number has no value then there is no information about the inputed name. 
        
        return true;

        // if the name is in our book return true
    }


    void StoreContact(string name, string address, string phone)
    {
        name = prettyInput(name);
        // standardizes the name user inputed.

        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":address", itemValue: address);
        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":phone", itemValue: phone);
        // this method saves the data on local storage corresponding with name user inputed.

    }


    public void NewContact()
    {
        string name = SnapsEngine.ReadString("Enter new contact name");

        string address = SnapsEngine.ReadMultiLineString("Enter contact address");
        // ReadMultiLineString is a method that allows a user to input more than one line

        string phone = SnapsEngine.ReadString("Enter contact phone");
        // asks user name, address, phone and sticks it into these variables.
        
        StoreContact(name, address, phone);
        // calls the StoreContact function to store the name, address, and phone of the new contact 
       
    }

     void FindContact()
    {
        string name = SnapsEngine.ReadString("Who are you looking for?");
        // asks user what contact's information he/she are looking for.

        string contactPhone, contactAddress;
        // variables to place values that are in local storage

        if (FetchContact(name: name, address: out contactAddress, phone: out contactPhone))
            // if there is information on a contact the user entered
        {
            SnapsEngine.ClearTextDisplay();
            SnapsEngine.AddLineToTextDisplay("Name:" + name);
            SnapsEngine.AddLineToTextDisplay("Address:" + contactAddress);
            SnapsEngine.AddLineToTextDisplay("Phone:" + contactPhone);

            // display the contact's information

        }

        else
        {
            SnapsEngine.DisplayString("This person is not on file");

            // if the person does no exist, let user know.
        }

        SnapsEngine.WaitForButton("Continue");

        // a Continue button appears for the user to click on to find a different contact or add a contact

        SnapsEngine.ClearTextDisplay();
    }



    public void StartProgram()
    {
        while (true)
            // run this until user exits program
        {
            SnapsEngine.SetTitleString("Tiny Contacts");
            SnapsEngine.Delay(3);
            // after the phrase Tiny Contacts is displayed. wait for three seconds
         

           string select = SnapsEngine.SelectFrom2Buttons("New Contact", "Find Contact");
            // two buttons appear named "New Contact" and "Find Contact" for user to click. Whichever button user clicks it is stored in the variable select

            if (select == "New Contact")
                // if user clicks on New Contact run the NewContact method.
            {
                NewContact();
                // shifts control to newContact method

            }

            else
            {
                // if the user clicks Find Contact run the FindContact method.
                FindContact();
                // shifts control to findContact method
                
            }


        }
    }
}


