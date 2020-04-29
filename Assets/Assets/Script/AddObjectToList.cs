using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
		
		copy.GetComponent<Button>().onClick.AddListener(
			() => 
			{
				SceneManager.LoadScene(1);
			}
		);
		
		index++;
	}
}
