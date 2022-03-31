using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
public class TelephoneTask : MonoBehaviour
{
	public Button[] numbers;
	public int[] tel = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
	public int[] tel2 = { 5, 9, 8, 7, 5, 4, 2, 3 };
	int i = 0;
	public GameObject questReport2;
	public GameObject QM;

	void Start()
	{

		tel[0] = 5;
		tel[1] = 9;
		tel[2] = 8;
		tel[3] = 7;
		tel[4] = 5;
		tel[5] = 4;
		tel[6] = 2;
		tel[7] = 3;
	}
	void Update()
    {
    }

	public void telLlamada(int n)
    {
		SoundManager.PlaySound("KeyboardSound");
		tel2[i] = n;

		i++;

		if(i==8)
		   {
				Comprobacion();
				i = 0;
			}

	}

	private void Comprobacion()
    {
		for (int i = 0; i < tel2.Length; ++i)
		{
			if(tel2[i]!=tel[i])
            {
				SoundManager.PlaySound("ErrorSound");
				Debug.Log("Error");
				break;
            }
            else if(i==7)
            {
				SoundManager.PlaySound("TaskCompletedSound");
				questReport2.SetActive(true);
				gameObject.GetComponent<Task>().EndQuest();
			}
		}
	}

}