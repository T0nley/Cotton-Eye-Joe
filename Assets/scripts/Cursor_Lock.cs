using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Lock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Releases the cursor
        Cursor.lockState = CursorLockMode.None;

        // Locks the cursor
        Cursor.lockState = CursorLockMode.Locked;

        // Confines the cursor
        Cursor.lockState = CursorLockMode.Confined;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
