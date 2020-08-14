using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public Camera MainCamera;

	private Vector3 character1 = new Vector3(124, 355, -10);
    private Vector3 character2 = new Vector3(370, 353, -10);
    private Vector3 character3 = new Vector3(621, 362, -10);
    private Vector3 character4 = new Vector3(825, 350, -10);

	void Start()
	{
	}

	public void ButtonMoveScene(string level)
    {
    	SceneManager.LoadScene(level);
    }

    void Update()
    {
    	if(Input.GetKeyDown (KeyCode.Escape))
    		SceneManager.LoadScene("Welcome");
    }
}
