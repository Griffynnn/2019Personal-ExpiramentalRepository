using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShowMainMenu();
    }
	void ShowMainMenu  ()  {
        Terminal.ClearScreen();
        string greeting = "Welcome User";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What Would You Like to Hack Into?");
        Terminal.WriteLine("Press 1, for the Police Station");
        Terminal.WriteLine("Press 2, for the treasury");
        Terminal.WriteLine("Enter your Selection Below:");
    }
    //Learned about how variables work today. Variables are like boxes, containing things like amount of lives, speed amounts, many things
    //a String is a string of characters. like "hello" string of letters


	// Update is called once per frame
	void Update () {
		
	}
}
