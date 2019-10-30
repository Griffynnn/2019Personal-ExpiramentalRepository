using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //member variables, available everywhere. put them up here at the top, we call this the game state
    int level;
    enum Screen { MainMenu, GuessPassword, WinScreen};
    Screen currentScreen;
    


	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }
	void ShowMainMenu()
    {
        Screen currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome User");
        Terminal.WriteLine("What Would You Like to Hack Into?");
        Terminal.WriteLine("Press 1, for the Police Station");
        Terminal.WriteLine("Press 2, for the treasury");
        Terminal.WriteLine("Enter your Selection Below:");
    }
    //Learned about how variables work today. Variables are like boxes, containing things like amount of lives, speed amounts, many things
    //a member variable is available for all functions, but inside it is only available for that set function ex: inside OnUserInput, only available there. if its outside, its available for any function. 
    //every function should only handle ONE thing. OnUserInput decides how to handle an input, but not actually do it. 
    void OnUserInput(string input)
    {
        if (input == "Menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "UwU")
        {
            Terminal.WriteLine("OwO Whats this? wrong wevel sewection! pwease imput a vawid wevel pweeeeeze...uwu");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level entry, type 'Menu' to return to main menu.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.GuessPassword;
        Terminal.WriteLine("You have chosen level" + level);
        Terminal.WriteLine("Please enter your password");
    }
    //Functions vs messages, using input as what the "player" types, making it print out on the console and the terminal.
    //messages get called from the outside, like an island, the message comes in. the "input" then is called to wherever. (console, terminal)
    //boolean, or bool. true or false.

}
