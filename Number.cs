using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
	public Button yourButton;
	public TelephoneTask tel;
	public int numero;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		tel.GetComponent<TelephoneTask>().telLlamada(numero);
	}
}
