using UnityEngine;

public class Chicken : Animal
{
   
    private int eggs;
    public int Eggs
    {
        get => eggs;
        private set
        {
            if (value < 0)
            {
                eggs = 0;
            }
            else
            {
                eggs = value;
            }
        }
    }

    public void init(string name, int hunger, int happiness, int eggs)
    {
        base.init(name, hunger, happiness);
        Eggs = eggs;
    }


    public void MakeSound()
    {
        Debug.Log($"{Name} says: Cluck!");
    }

    public void GetStatus()
    {
        Debug.Log($"[Chicken Status] Name: {Name}, Hunger: {Hunger}, Happiness: {Happiness}, Eggs: {Eggs}");
    }
}