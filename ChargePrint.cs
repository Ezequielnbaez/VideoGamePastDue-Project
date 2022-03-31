using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargePrint : MonoBehaviour
{
    [SerializeField] private GameObject Holder;
    public Image timer_linear_image;

    void Start()
    {
        Holder.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKey("space") && other.tag == "Player")
        {
            timer_linear_image.fillAmount += 0.0018f;
            if (timer_linear_image.fillAmount == 1)
            {
                SoundManager.PlaySound("TaskCompletedSound");
                Holder.SetActive(false);
                gameObject.GetComponent<Task>().EndQuest();
            }
        }
    }
}
