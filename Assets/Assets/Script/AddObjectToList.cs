using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddObjectToList : MonoBehaviour
{
	int index = 0;
	
	public GameObject itemTemplate;
	
	public GameObject content;
	
	public void AddButton_Click()
	{
		var copy = Instantiate(itemTemplate);
		copy.transform.parent = content.transform;
		
		copy.GetComponentInChildren<Text>().text = "Project" + (index+1).ToString();
		index++;
	}
}
