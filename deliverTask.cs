using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliverTask : MonoBehaviour
{
    void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<Task>().EndQuest();
        }
    }
}
