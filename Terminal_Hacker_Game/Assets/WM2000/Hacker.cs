using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }
	void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome User");
        Terminal.WriteLine("What Would You Like to Hack Into?");
        Terminal.WriteLine("Press 1, for the Police Station");
        Terminal.WriteLine("Press 2, for the treasury");
        Terminal.WriteLine("Enter your Selection Below:");
    }
    //Learned about how variables work today. Variables are like boxes, containing things like amount of lives, speed amounts, many things
    //a String is a string of characters. like "hello" string of letters
    void OnUserInput(string input)
    {
        //Terminal.WriteLine("User has typed..." + input);
        if (input == "Menu")
        {
            ShowMainMenu();
        }
        else if (input == "UwU")
        {
            Terminal.WriteLine("OwO Whats this? wrong wevel sewection! pwease imput a vawid wevel pweeeeeze... UwU");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level entry, type 'Menu' to return to main menu.");
        }
    }
    //Functions vs messages, using input as what the "player" types, making it print out on the console and the terminal.
    //messages get called from the outside, like an island, the message comes in. the "input" then is called to wherever. (console, terminal)
    //boolean, or bool. true or false.

}
