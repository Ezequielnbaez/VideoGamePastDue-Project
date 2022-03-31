using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrintReport : MonoBehaviour
{
    [SerializeField] private GameObject Holder;
    public Image timer_linear_image;
    void Start()
    {
        Holder.SetActive(true);
    }

    void Update()
    {


    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown("space") && other.tag == "Player")
        {
            timer_linear_image.fillAmount += 0.08f;

            if (timer_linear_image.fillAmount == 1)
            {
                Holder.SetActive(false);
                SoundManager.PlaySound("TaskCompletedSound");
                gameObject.GetComponent<Task>().EndQuest();
            }
        }
    }

}
