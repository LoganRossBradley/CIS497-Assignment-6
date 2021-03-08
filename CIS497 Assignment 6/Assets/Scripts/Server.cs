/* Logan Ross
 * Server.cs 
 * Assignment 6 
 * Sets up the different tasks a server can do
 */

using UnityEngine;
using System.Collections;

    public class Server : GeneralWorker
    {

    public void takeOrder()
    {
        Debug.Log(name + " has taken an order");
    }

    public void deliverFood()
    {
        Debug.Log(name + " has delivered an order to the customer");
    }
}