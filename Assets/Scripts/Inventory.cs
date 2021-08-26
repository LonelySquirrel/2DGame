using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    GameObject inventory;

    //De är public så att andra scripts har tillgång till dem.
    public bool[] slotsUsed; // ( Kollar om sloten är full.
    public GameObject[] slots; 
  
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if ( inventory.tag == "Close")// Byter mellan att ha menyn öppen och stängd
            {
                print("Opening"); //debug

                inventory.SetActive(true);
                inventory.tag = "Open";
                
            }
            else if ( inventory.tag == "Open")
            {
                print("Closing"); //debug

                inventory.SetActive(false);
                inventory.tag = "Close";

            }
        }
        
        
    }

   
}

