using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

    public Text story; // create a variable called "story" of the Text type; public means we'll see it in the WYSIWYG inspector 
    
	private enum States {one, two, three, four, five, six, seven, eight}; // use enum to articulate the eight states or constants of our game; private means we won't see it in the WYSIWYG inspector 

	private States myState; // create a variable called "myState" of the States type; private means we won't see it in the WYSIWYG inspector 
    
    // Initialize our game; this will only run once 
	void Start () {
	    myState = States.one; // our first state is state one (e.g., "you're in a room")
	}
	
	// Now run the following once per frame 
	void Update () {
		print (myState);
		if (myState == States.one) 			{state_one();}
		else if (myState == States.two) 	{state_two();}
		else if (myState == States.three) 	{state_three();}
		else if (myState == States.four) 	{state_four();}
		else if (myState == States.five) 	{state_five();}
		else if (myState == States.six) 	{state_six();}
		else if (myState == States.seven) 	{state_seven();}
		else if (myState == States.eight) 	{state_eight();}
	}
	
	void state_one () {
		story.text = "You're in the middle of a room.\n\n" +
					 "Press L to move left, " +
					 "F to move forward, " +
					 "or R to move right.";
		if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.two;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.three;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.four;}
    }
    
	void state_two() {
		story.text = "You've stepped on a nail.\n\n" +
					 "Press M to remove it and return to " + 
					 "the middle of the room." ;
		if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.one;}
    }
    
	void state_three() {
		story.text = "You've encountered a door.\n\n" +
					 "Press O to open it " +
					 "or M to return to " +
					 "the middle of the room.";
		if (Input.GetKeyDown(KeyCode.O)) 		{myState = States.five;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.one;}
    }
   
    void state_four () {
		story.text = "You've stepped in some coffee.\n\n" +
					 "Press M to wipe it off and return to " +
					 "the middle of the room." ;
        if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.one;}
    }
    
	void state_five() {
		story.text = "You're in a hallway.\n\n" + 
					 "Press D to dance, "+
					 "J to jump, " + 
					 "or C to cry." ;
		if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.six;}
		else if (Input.GetKeyDown(KeyCode.J)) 	{myState = States.seven;}
		else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.eight;}
    }
    
    void state_six() {
		story.text = "The speakers blast your favourite song. " +
					 "You could dance forever.\n\n" + 
					 "Press D to dance forever " +
					 "or H to stand still in the hallway.";
		if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.six;}
		else if (Input.GetKeyDown(KeyCode.H))	{myState = States.five;}
    }
    
	void state_seven() {
		story.text = "Your remember you forgot how to jump.\n\n" + 
					 "Press J to keep trying " + 
					 "or H to stand still in the hallway." ;
		if (Input.GetKeyDown(KeyCode.J)) 		{myState = States.seven;}
		else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.five;}
    }
    
	void state_eight() {
		story.text = "Your tears awaken you from this nitemare.\n\n" +
					 "Press P to play again.";
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.one;}
    }
}
