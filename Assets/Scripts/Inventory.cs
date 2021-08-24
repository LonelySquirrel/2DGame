using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            if ( inventory == false)// Byter mellan att ha menyn öppen och stängd
            {
                print("Opening"); //debug

                inventory.SetActive(true);
            }
            else if ( inventory == true)
            {
                print("Closing"); //debug

                inventory.SetActive(false);

            }
        }
        
        
    }

   
}

