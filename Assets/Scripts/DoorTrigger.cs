using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Door>().opening = true;
        door.GetComponent<Door>().closing = false;
    }

    private void OnTriggerExit(Collider other)
    {
        door.GetComponent<Door>().closing = true;
        door.GetComponent<Door>().opening = false;
    }
}
