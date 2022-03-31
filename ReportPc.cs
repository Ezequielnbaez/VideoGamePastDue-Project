using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReportPc : MonoBehaviour
{
    [SerializeField] private GameObject report;
    public Image[] letters;
    public string[] letras = new string[] {"c","e","f","g","h","i","j","k","l","n","o","p","q","r","t","u","v","x","y","z"};
    public bool tocado = false;
    public int cantLetras = 20;
    public GameObject questTel;
    public QuestManager QM;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WritinReport());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WritinReport()
    {
        report.SetActive(true);
        // do stuff here, show win screen, etc.
        for (int i = 0; i < cantLetras; i ++)
        {
            // just a simple time delay as an example
            //yield return new WaitForSeconds(0.5f);
            // wait for player to press space
            yield return waitForKeyPress(letras[Random.Range(0, letras.Length)]); // wait for this function to return

            // do other stuff after key press
        }
        SoundManager.PlaySound("TaskCompletedSound");

        if (!QM.GetComponent<QuestManager>().questCompleted[1])
        {
            questTel.SetActive(true);
        }


            report.SetActive(false);
            gameObject.GetComponent<Task>().EndQuest();
            

    }

    private IEnumerator waitForKeyPress(string key)
    {
        Image letra=null;
        float yPos = 0f;
        float xPos = 18f;
        foreach (Image go in letters)
        {
            if (go.name == key )
            {
                yPos = Random.Range(-10, 10f);
                xPos = Random.Range(-10, 10f);
                letra = go;
                letra.transform.position = new Vector3(xPos, yPos, 0);
                letra.GetComponent<Image>().enabled = true;
                break;
            }
        }
        Debug.Log("Presiona:"+key);
        bool done = false;
        while (!done) // essentially a "while true", but with a bool to break out naturally
        {
            if (Input.GetKeyDown(key))
            {
                SoundManager.PlaySound("KeyboardSound");
                done = true; // breaks the loop
            }
            yield return null; // wait until next frame, then continue execution from here (loop continues)
        }
        letra.GetComponent<Image>().enabled = false;
        // now this function returns
    }
}
