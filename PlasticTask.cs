using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticTask : MonoBehaviour
{
    [SerializeField] private GameObject interfaz;
    public DropSlot[] ds;
    public GameObject quest;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsAllPapersComplete())
        {
            interfaz.SetActive(false);
            quest.SetActive(true);
            SoundManager.PlaySound("TaskCompletedSound");
            gameObject.GetComponent<Task>().EndQuest();
        }

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            interfaz.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        interfaz.SetActive(false);
    }


    private bool IsAllPapersComplete()
    {
        for (int i = 0; i < ds.Length; ++i)
        {
            if (ds[i].ocupado == false)
            {
                return false;
            }
            else if(ds.Length==i)
            {
                return true;
            }

        }
        return true;

    }


}
