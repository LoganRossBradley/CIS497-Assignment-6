/* Logan Ross
 * ShiftSupervisor.cs 
 * Assignment 6 
 * Sets up the overarching employee class that all employees inherit
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour
{
    private string name;
    private int emploeeID;

    public int getEmployeeID()
    {
        return emploeeID;
    }
    public string getName()
    {
        return name;
    }
}
