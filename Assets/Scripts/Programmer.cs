using UnityEngine;

public class Programmer : MonoBehaviour
{
    // Encapsulation
    private int energy = 100;
    private int tasksCompleted = 0;

    public int Energy
    {
        get { return energy; }
        set { energy = Mathf.Clamp(value, 0, 100); }
    }

    public virtual void Work()
    {
        tasksCompleted++;
        Energy -= 10;
        Debug.Log("Programmer completed a task. Energy now: " + Energy);
    }
}
