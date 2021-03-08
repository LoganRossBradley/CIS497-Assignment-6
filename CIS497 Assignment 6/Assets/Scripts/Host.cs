
/* Logan Ross
 * Host.cs 
 * Assignment 6 
 * Sets up the different tasks a Host can do
 */
using UnityEngine;
using System.Collections;

    public class Host : GeneralWorker
    {

        public void takeReservation()
    {
        Debug.Log(name + "  has taken a reservation");

    }
    public void seatCustomer()
    {
        Debug.Log(name + "  has taken a customer to their seat");

    }
}