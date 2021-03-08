/* Logan Ross
 * Cook.cs 
 * Assignment 6 
 * Sets up the different tasks a cook can do
 */

using UnityEngine;
using System.Collections;


    public class Cook : GeneralWorker
    {

        public void cookFood(string foodToCook)
    {
        Debug.Log(name + " is cooking " + foodToCook);
    }
    }