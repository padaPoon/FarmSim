using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;
    private int hunger;
    private int happiness;

    public string Name
    {
        get => name;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Debug.Log("Invalid name");
            }
        }
    }
    public int Hunger
    {
        get => hunger;
        set
        {
            if (value < 0)
            {
                hunger = 0;
            }
            else if (value > 50)
            {
                hunger = 50;
            }
            else
            {
                hunger = value;
            }
        }
    }
    public int Happiness
    {
        get => happiness;
        set
        {
            if (value < 0)
            {
                happiness = 0;
            }
            else if (value > 50)
            {
                happiness = 50;
            }
            else
            {
                happiness = value;
            }
        }
    }
    public void init(string name, int hunger, int happiness)
    {
        Name = name;
        Hunger = hunger;
        Happiness = happiness;
    }
    public void AdjustHunger(int amount)
    {
        Hunger = Hunger + amount;
        Debug.Log($"{Name} Hunger adjusted to {Hunger}");
    }

    public void AdjustHappiness(int amount)
    {
        Happiness = Happiness + amount;
        Debug.Log($"{Name} Happiness adjusted to {Happiness}");
    }
    public void Feed(string food)
    {
        AdjustHunger(-10);
        AdjustHappiness(5);
        Debug.Log($"{Name} was fed {food}.");
    }
    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);
        Debug.Log($"{Name} is sleeping...");
    }
}
