using UnityEngine;

public class JuniorProgrammer : Programmer
{
    public override void Work()
    {
        Energy -= 15; // Junior loses energy faster
        Debug.Log("Junior Programmer Googles the solution and slowly completes a task. Energy: " + Energy);
    }
}
