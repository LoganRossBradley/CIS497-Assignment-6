
/* Logan Ross
 * GameManager.cs 
 * Assignment 6 
 * manages all of the code for the buttons that create employees and restart the scene
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class GameManager : MonoBehaviour
    {
    public GameObject cookPrefab;
    public Vector3 cookLocation = new Vector3(-2.6f, -1.3f, 3.7f) ;
    public GameObject hostPrefab;
    public Vector3 hostLocation = new Vector3(5.9f, -1.3f, 3.7f);
    public GameObject serverPrefab;
    public Vector3 serverLocation = new Vector3(5.2f, -5.5f, -2.2f);
    public GameObject siftSupervisorPrefab;
    public Vector3 shiftSupervisorLocation = new Vector3(-3.08f, -5.5f, -2.2f);

    public Text txtEmployeesLeft;
    public int numEmps;
    private void Update()
    {
        numEmps = GameObject.FindGameObjectsWithTag("Employee").Length;
        txtEmployeesLeft.text = 6 - numEmps + " employees left";
    }
    public void createServer()
    {
        if(numEmps < 6)
        {
            Instantiate(serverPrefab, serverLocation, new Quaternion(0, 0, 0, 0));
            serverLocation.x += 1.5f;
        }

    }
    public void createCook()
    {
        if (numEmps < 6)
        {
            Instantiate(cookPrefab, cookLocation, new Quaternion(0, 0, 0, 0));
            cookLocation.x += 1.5f;
        }
        }
    public void createHost()
    {
        if (numEmps < 6)
        {
            Instantiate(hostPrefab, hostLocation, new Quaternion(0, 0, 0, 0));
            hostLocation.x += 1.5f;
        }
    }
    public void createShiftSupervisor()
    {
        if (numEmps < 6)
        {
            Instantiate(siftSupervisorPrefab, shiftSupervisorLocation, new Quaternion(0, 0, 0, 0));
            shiftSupervisorLocation.x += 1.6f;
        }
    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}