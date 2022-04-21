using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Animator anime;
    bool doorOpen;


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        doorOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            doorOpen = true;
            anime.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (doorOpen)
        {
            doorOpen = false;
            anime.SetTrigger("Close");
        }
    }
}
