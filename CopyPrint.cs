using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyPrint : MonoBehaviour
{
    [SerializeField] private GameObject Holder;
    public Image timer_linear_image;
    private bool[] probs = new bool[10];
    public GameObject quest;

    void Start()
    {
        Holder.SetActive(true);
        probs[0] = false;
        probs[1] = false;
        probs[2] = true;
        probs[3] = false;
        probs[4] = false;
        probs[5] = true;
        probs[6] = false;
        probs[7] = false;
        probs[8] = true;
        probs[9] = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (probs[Random.Range(0, probs.Length)])
            {
                startIn();
            }
            else
            {
                task();
            }
        }

    }

    public void startIn()
    {
        StartCoroutine(waitCouple());
    }

    IEnumerator waitCouple()
    {
        yield return new WaitForSeconds(3);
    }

    private void task()
    {
            if (Input.GetKey("j") || Input.GetKey("l"))
            {
                timer_linear_image.fillAmount += 0.003f;
                if (timer_linear_image.fillAmount == 1)
                {
                    quest.SetActive(true);
                    SoundManager.PlaySound("TaskCompletedSound");
                    Holder.SetActive(false);
                    gameObject.GetComponent<Task>().EndQuest();
                }
            }
    }

}
