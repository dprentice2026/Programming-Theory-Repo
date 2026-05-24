using UnityEngine;

public class ToolsEngineer : Programmer
{
    public override void Work()
    {
        Energy -= 5; // Tools Engineer is efficient and loses less energy
        Debug.Log("Tools Engineer optimizes tools and quickly completes a task. Energy: " + Energy);
    }
}
