using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chicken chicken;
    public Cow cow;


    void Start()
    {
        //Create Stats chicken and cow
/*        Chicken chicken = new Chicken("Chicken", 50, 50, 0);
        Cow cow = new Cow("Cow", 50, 50, 0); 
*/

        chicken.init("Chicken", 50, 50, 0);
        cow.init("Cow", 50, 50, 0);

        //Show Stats on start game
        chicken.GetStatus();
        cow.GetStatus();

        //Start Game
        Debug.Log("---- Gameplay Start ----");

        chicken.MakeSound();
        chicken.Feed("Corn");
        chicken.Sleep();
        chicken.AdjustHunger(15);
        chicken.AdjustHappiness(-5);

        cow.MakeSound();
        cow.Feed("Grass");
        cow.Sleep();
        cow.AdjustHunger(-20);
        cow.AdjustHappiness(10);

        //Show Stats after action
        Debug.Log("---- After Actions ----");
        chicken.GetStatus();
        cow.GetStatus();
    }
}