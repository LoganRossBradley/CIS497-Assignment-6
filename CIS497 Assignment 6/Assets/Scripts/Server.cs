using UnityEngine;
using System.Collections;

    public class Server : GeneralWorker
    {
    public GameObject serverPrefab;

    public void createServer()
    {
        Instantiate(serverPrefab);
    }

    public void takeOrder()
    {
        Debug.Log(name + " has taken an order");
    }

    public void deliverFood()
    {
        Debug.Log(name + " has delivered an order to the customer");
    }
}