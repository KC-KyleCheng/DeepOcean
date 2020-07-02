using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptCharacterSelection : MonoBehaviour
{

	Camera MainCamera;
	public Camera Camera2;

	void Start()
	{
		MainCamera = Camera.main;
		MainCamera.enabled = true;
		Camera2.enabled = false;
	}

	public void ButtonMoveScene(string level)
    {
    	SceneManager.LoadScene(level);
    }

    public void ButtonMoveCamera()
    {
    	if(MainCamera.enabled)
    	{
    		Camera2.enabled = true;
    		MainCamera.enabled = false;
    	}
    	else
    	{
    		Camera2.enabled = false;
    		MainCamera.enabled = true;
    	}
    }

    void Update()
    {
    	if (Input.GetKeyDown (KeyCode.Escape))
    		SceneManager.LoadScene("ScnWelcome");
    }
}
