using UnityEngine;

public class OfficeManager : MonoBehaviour
{
    public Programmer[] programmers;

    void Start()
    {
        Debug.Log("Office Manager ready. Programmers in the office: " + programmers.Length);
    }

    public void AssignTasks()
    {
        foreach (Programmer p in programmers)
        {
            p.Work();   // Polymorphism happens here
        }
    }
}
