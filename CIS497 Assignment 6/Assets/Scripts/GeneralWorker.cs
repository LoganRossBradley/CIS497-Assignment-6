/* Logan Ross
 * ShiftSupervisor.cs 
 * Assignment 6 
 * Sets up the abstact woker class for basic employees
 */

using UnityEngine;
using System.Collections;

    public abstract class GeneralWorker : Employee
    {

    private string workerType;
    private float payRate;

    public void changePayRate(float newPay)
    {
        payRate = newPay;
    }
    public float getPayRate()
    {
        return payRate;
    }
    public string getWorkertype()
    {
        return workerType;
    }
    }