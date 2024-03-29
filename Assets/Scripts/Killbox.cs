using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject cubeRespawn;

    public AudioSource playerInteraction;
    public AudioSource objectInteraction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
            playerInteraction.Play();
        }
        else if (other.gameObject.CompareTag("grabcube"))
        {
            other.gameObject.transform.position = cubeRespawn.transform.position;
            objectInteraction.Play();
        }
    }
}
