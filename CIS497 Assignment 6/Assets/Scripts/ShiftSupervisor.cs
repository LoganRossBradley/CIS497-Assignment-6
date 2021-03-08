/* Logan Ross
 * ShiftSupervisor.cs 
 * Assignment 6 
 * Sets up the different tasks a shift supervisor can do
 */

using UnityEngine;
using System.Collections;

    public class ShiftSupervisor : Supervisor
    {

        public void closeStore()
    {
        Debug.Log(name + " closed the store");
    }
    public void openStore()
    {
        Debug.Log(name + " opened the store");
    }
}