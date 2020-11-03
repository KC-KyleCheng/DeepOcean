using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
	void Start()
	{
		GameObject.FindGameObjectWithTag("Bgm_Welcome").GetComponent<Bgm_Welcome>().PlayMusic();
	}

	public void ButtonMoveScene(string level)
    {
    	SceneManager.LoadScene(level);
    }

    void Update()
    {
    	if (Input.GetKeyDown (KeyCode.Escape))
    		Application.Quit();
    }
}
