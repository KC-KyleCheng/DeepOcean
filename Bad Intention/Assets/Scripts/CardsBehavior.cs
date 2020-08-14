using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardsBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    //private Vector3 startPosition;
    public Transform effect;
    public Transform option;

    public Sprite[] cardsSprite;

    public int cardType; // 0 for Club, 1 for Dimond, 2 for Heart, 3 for Spade
    void Start()
    {
        //Screen.SetResolution(1080, 1920, false);
        Screen.fullScreen = false;
        //startPosition = transform.localPosition;
        effect = GameObject.Find("ScriptsControl").GetComponent<Effect>().effect;
        option = GameObject.Find("ScriptsControl").GetComponent<Option>().option;
        cardType = Random.Range(0, 4);

        GetComponent<Image>().sprite = cardsSprite[cardType];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
            SceneManager.LoadScene("Main");
    }

    public void Enter()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);

    }

    public void Exit()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);

    }

    public void Drag()
    {   

        if (Position.onTimeCard != null && Position.onTimeCard != this.gameObject)
        {
            return;
        }


        transform.position = Input.mousePosition;
        transform.SetParent(GameObject.Find("Temp").transform);
        option.gameObject.SetActive(false); //////////////
        //Debug.Log(Vector3.Distance(transform.position, effect.position));
        if (Vector3.Distance(transform.position, effect.position) < 100)
        {
            effect.gameObject.SetActive(true);
        }
        else
        {
            effect.gameObject.SetActive(false);
        }
    }

    public void Up()
    {
        
        
        
        if (Vector3.Distance(transform.position, effect.position) < 100)
        {
            transform.SetParent(GameObject.Find("Temp").transform);
            Position.onTimeCard = this.gameObject;
            transform.position = effect.position;
            effect.gameObject.SetActive(false);
            option.gameObject.SetActive(false);
        }
        else
        {
            transform.SetParent(GameObject.Find("Cards").transform);
            if (Position.onTimeCard = this.gameObject)
            {
                Position.onTimeCard = null;
            }
            
            effect.gameObject.SetActive(false);
            option.gameObject.SetActive(true);
        }
    }
}
