using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptCharacterSelection : MonoBehaviour
{

	public Image Character1Detail;
	public Image Character2Detail;
	public Image Character3Detail;
	public Image Character4Detail;

	public GameObject StartCharacter1;

	public Camera MainCamera;

	private Vector3 character1 = new Vector3(124, 390, -10);
    private Vector3 character2 = new Vector3(454, 307, -10);
    private Vector3 character3 = new Vector3(800, 390, -10);
    private Vector3 character4 = new Vector3(825, 246, -10);

	void Start()
	{
		Character1Detail.enabled = false;
		Character2Detail.enabled = false;
		Character3Detail.enabled = false;
		Character4Detail.enabled = false;

		StartCharacter1.SetActive(false);
	}

	public void ButtonMoveScene(string level)
    {
    	SceneManager.LoadScene(level);
    }

    public void Character1Pressed()
    {    	
    	StartCharacter1.SetActive(true);
    }

    void Update()
    {
    	if(Input.GetKeyDown (KeyCode.Escape))
    		SceneManager.LoadScene("ScnWelcome");

    	if(MainCamera.transform.position == character1)
    	{
    		Character1Detail.enabled = true;
    		Character2Detail.enabled = false;
			Character3Detail.enabled = false;
			Character4Detail.enabled = false;
    		//GetComponent<Animation>().Play("fade_show");
    	}
    	if(MainCamera.transform.position == character2)
    	{
    		Character1Detail.enabled = false;
    		Character2Detail.enabled = true;
			Character3Detail.enabled = false;
			Character4Detail.enabled = false;
			StartCharacter1.SetActive(false);
    	}
    	if(MainCamera.transform.position == character3)
    	{
    		Character1Detail.enabled = false;
    		Character2Detail.enabled = false;
			Character3Detail.enabled = true;
			Character4Detail.enabled = false;
			StartCharacter1.SetActive(false);
    	}
    	if(MainCamera.transform.position == character4)
    	{
    		Character1Detail.enabled = false;
    		Character2Detail.enabled = false;
			Character3Detail.enabled = false;
			Character4Detail.enabled = true;
			StartCharacter1.SetActive(false);
    	}
    }
}
