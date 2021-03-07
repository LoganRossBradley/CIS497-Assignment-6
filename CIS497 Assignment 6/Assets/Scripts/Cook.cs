using UnityEngine;
using System.Collections;


    public class Cook : GeneralWorker
    {

        public void cookFood(string foodToCook)
    {
        Debug.Log(name + " is cooking " + foodToCook);
    }
    }