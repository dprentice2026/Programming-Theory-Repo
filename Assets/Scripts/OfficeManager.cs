using UnityEngine;

public class OfficeManager : MonoBehaviour
{
    // Manager class that holds a list of Programmer objects and calls their Work() methods.
    // Demonstrates Polymorphism by treating all programmers as the base type.

    public Programmer[] programmers;

    void Start()
    {
        Debug.Log("Office Manager ready. Programmers in the office: " + programmers.Length);
    }

    public void AssignTasks()
    {
        // ABSTRACTION

        foreach (Programmer p in programmers)
        {
            p.Work();   // Polymorphism happens here
        }
    }
}
