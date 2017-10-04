/* 
In Unity, make sure it's easy to discern "play mode" from "scene mode" by changing your playmode tint under Preferences/Colors.
Also in Unity, move your Console window to the far right. This way, you can see it as you write C# in MonoDevelop (to the left of your console). MonoDevelop is an IDE for Unity.   
In MonoDevelop, change your indenting preferences to Automatic: Preferences/Text Editor/Behavior/Automatic. 
Semicolons are required at the end of each line in C#. 
Use // to comment on or explain your C# code.
Use print("TEXT HERE"); to print a string in C#. Printed text will appear in orange.  
int means integer (whole numbers) in C# int will appear in blue.
Errors will appear in red.    
Don't forget to close your parentheses/brackets.  
Use { } to create code blocks in C#.  
Anything under void Start () runs only once (when the script begins). 
Anything under void Update () runs once per frame (dictated by the frame rate).   
If you want to search for more info about a command from within MonoDevelop, press command + ' next to that command.
When you check a script in the Unity console, consider selecting the "Collapse" option (left of "Clear on Play"). This option counts occurrences instead of printing them each time. 
Press command + B or F8 to build your script in MonoDevelop. 
The program below has two functions: Start and Update.  
To run this program in Unity, you'll need a project (call it "numberGame"), a component called "numberGame", and a scene (call it "main"). 
When naming files, use Camel Case (no spaces; capital letters to mark new words; lower case for the first word.)
*/ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberGame : MonoBehaviour {

	// Declare your variables 
	
	int max; // declare a variable of the integer type (a whole number) and call it "max" 
	int min; // declare a variable of the integer type (a whole number) and call it "min" 
	int guess; // declare a variable of the integer type (a whole number) and call it "guess" 

	void Start () {

		max = 1000; // initialize the max variable at 1000
		min = 1; // initialize the min variable at 1
		guess = 500; // initialize the guess variable at 500
	
		print("Please think of a whole number between 1 and 1000."); // print a string to console
		print("Is the number higher or lower than " + guess + "? Press up for 'higher,' down for 'lower,' or return for 'same.'"); // print a string and an integer to the console 
	 	
		max = max + 1; // this resolves the "rounding problem" of the "binary chop" (see below); without it, you can't include 1000 (an edge case) in the game
	 	
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {  // define command for up arrow input from the reader
			min = guess; // initially set the minimum to 500
			guess = (max + min) / 2; // the "binary chop"; cut in half until you arrive at the answer 
			print("Is the number higher or lower than " + guess + "? Press up for 'higher,' down for 'lower,' or return for 'same.'");  // print a string and an integer to the console 
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) { // define command for down arrow input from the reader
			max = guess; // initially set the maximum to 500
			guess = (max + min) / 2; // the "binary chop"; cut in half until you arrive at the answer 
			print("Is the number higher or lower than " + guess + "? Press up for 'higher,' down for 'lower,' or return for 'same.'");  // print a string and an integer to the console  
		} else if (Input.GetKeyDown(KeyCode.Return)) { // define command for return key input from the reader
			print("My job here is done. We will not play again."); // print string to console responding to input 
		} // else if is used to ensure you cannot press all three keys at once 
	}
}
