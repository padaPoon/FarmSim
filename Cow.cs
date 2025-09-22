using UnityEngine;

public class Cow :Animal
{
    private int milk;

    // Properties
    public int Milk 
    { 
        get => milk; 
        private set => milk = value; 
    }

    //Constructor
    public void init(string newName, int newHunger, int newHappiness,int newMilk)
    {
        base.init(newName,newHunger,newHappiness);
        Milk = milk;
    }

    //Public Methods

    public void Play()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} played.");
    }

    
    public void Moo()
    {
        AdjustHappiness(10);
        Debug.Log($"{Name} says: Moo!");
    }

    public void MakeSound()
    {
        Moo(); 
    }

    public void ProduceMilk()
    {
        Milk++;
        AdjustHappiness(-5);
        Debug.Log($"{Name} produced milk. Total Milk = {Milk}");
    }

    public void GetStatus()
    {
        Debug.Log($"Cow: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Milk: {Milk}");
    }
}