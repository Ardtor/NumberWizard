using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max; 
    int min;
    int guess;

    // Use this for initialization
    void Start ()

    {
        StartGame();
	}

    // Update is called once per frame
	void Update ()
	{

	    if (Input.GetKeyDown("up"))
	    {
	        // print("Up Arrow Pressed");
	        min = guess;
            NextGuess();
	        
	    }
        else if (Input.GetKeyDown("down"))
	    {
            //print("Down Arrow Pressed");
	        max = guess;
	        NextGuess();
        }
	    else if (Input.GetKeyDown("return"))
	    {
	        print("I won!");
            StartGame();
	    }
    }


    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = UnityEngine.Random.Range (1,1000);
        
        

        print("=====================================================");
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me");


        print("The Highest number you can pick is " + max + " and the lowest number you can pick is " + min);


        print("Is the number higher or lower than " + guess + " ?");
        print("Up arrow for higher, down for lower, return for equal");
        max = max + 1;

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + " ?");
        print("Up arrow for higher, down for lower, return for equal");
    }
}
