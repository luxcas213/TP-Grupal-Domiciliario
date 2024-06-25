using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class menusManager : MonoBehaviour
{
	public GameObject[] menus;
	public spawns spawns; 
	public TMP_InputField inputF;

	public void Salir()
	{
		SceneManager.LoadScene(0);
	}

	public void RestartScene()
	{
		SceneManager.LoadScene(1);
	}

	public void Responder()
	{
		if (string.IsNullOrEmpty(inputF.text))
		{
			InputFieldVacio();
		}
		else
		{
			int num = int.Parse(inputF.text);
			int cant = spawns.cantidad;

			if (num == cant)
			{
				Ganar();
			}
			else
			{
				Perder();
			}
			
			
		}
	}
	
	public void Perder()
	{
		SetActiveMenu(2);	
	}

	public void Ganar()
	{
		SetActiveMenu(3);
	}

	public void InputFieldVacio()
	{
		SetActiveMenu(1);
	}

	public void VolverElejir()
	{
		SetActiveMenu(0);
	}

	private void SetActiveMenu(int index)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			menus[i].SetActive(false);
		}
		if (index >= 0 && index < menus.Length)
		{
			menus[index].SetActive(true);
		}
	}
}
