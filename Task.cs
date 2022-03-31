using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public int questNumber;
    public QuestManager QM;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && gameObject.name == "ReportPc" && !QM.questCompleted[0])
        {
            writeTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Telephone" &&  QM.questCompleted[0])
        {
            telTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "ReportPc2" && QM.questCompleted[1])
        {
            writeTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Print" && QM.questCompleted[2])
        {
            printTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Charge" && QM.questCompleted[3])
        {
            chargeTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Photocopy" && QM.questCompleted[4])
        {
            copyTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Plastic" && QM.questCompleted[5])
        {
            plasticTask();
        }
        else if (other.gameObject.tag == "Player" && gameObject.name == "Deliver" && QM.questCompleted[6])
        {
            deliverTask();
        }

    }

  
    public void EndQuest()
    {
        QM.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }

    private void writeTask()
    {
        gameObject.GetComponent<ReportPc>().enabled = true;
    }
    private void printTask()
    {
        gameObject.GetComponent<PrintReport>().enabled = true;
    }
    private void chargeTask()
    {
        gameObject.GetComponent<ChargePrint>().enabled = true;
    }
    private void copyTask()
    {
        gameObject.GetComponent<CopyPrint>().enabled = true;
    }
    private void plasticTask()
    {
        gameObject.GetComponent<PlasticTask>().enabled = true;
    }
    private void telTask()
    {
        gameObject.GetComponent<TelephoneTask>().enabled = true;
        gameObject.GetComponent<TaskList>().enabled = true;
    }
    private void deliverTask()
    {
        gameObject.GetComponent<deliverTask>().enabled = true;
    }

}
