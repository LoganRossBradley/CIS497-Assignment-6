/* Logan Ross
 * Supervisor.cs 
 * Assignment 6 
 * Sets up abstract supervisor class for employees that have more permissions over general workers
 */

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