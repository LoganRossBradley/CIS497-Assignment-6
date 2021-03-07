using UnityEngine;
using System.Collections;

    public abstract class Supervisor: Employee
    {

    private int salary;

    public int getSalary()
    {
        return salary;
    }

    public void reportWorker(int workerID)
    {
        Debug.Log(name + " reported worker " + workerID);
    }
    }