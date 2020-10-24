using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cameras : MonoBehaviour
{
    private Vector3 dragOrigin;
    private Vector3 dragEnd;
    private Vector3 distance;
    private Vector3 cameraPosition;
    private Vector3 StartingPos;
    private Vector3 EndingPos;

    private Vector3 character1 = new Vector3(124, 355, -10);
    private Vector3 character2 = new Vector3(370, 353, -10);
    private Vector3 character3 = new Vector3(621, 362, -10);
    private Vector3 character4 = new Vector3(825, 350, -10);

    void Update ()
    {            
    	      
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Began)
            {
                dragOrigin = touch.position;
            }          

            if(touch.phase == TouchPhase.Moved)
            {
            	dragEnd = touch.position;       	                

        		distance = dragOrigin - dragEnd;

                EndingPos.x = StartingPos.x + distance.x/2;
                EndingPos.y = StartingPos.y + distance.y/2;

                EndingPos.x = Mathf.Min(EndingPos.x, 825);
                EndingPos.x = Mathf.Max(EndingPos.x, 124);
                EndingPos.y = Mathf.Min(EndingPos.y, 380);
                EndingPos.y = Mathf.Max(EndingPos.y, 300);

                //Debug.Log("EndingPos: " + EndingPos.x + "x" + EndingPos.y);

                float lerpValueX = Mathf.Lerp(StartingPos.x, EndingPos.x, (Time.time-2.0f)*0.2f);
                float lerpValueY = Mathf.Lerp(StartingPos.y, EndingPos.y, (Time.time-2.0f)*0.2f);

                transform.position = new Vector3(lerpValueX, lerpValueY, -10);   

            }
            
            if(touch.phase == TouchPhase.Ended)
            {
                cameraPosition = this.transform.position;
            }

        }     

        else
        {
        	if(Mathf.Abs(cameraPosition.x - character1.x) < 125 || cameraPosition.x < character1.x)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character1, 30);
                StartingPos = character1;
        	}

        	else if(Mathf.Abs(cameraPosition.x - character2.x) < 125)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character2, 30);
                StartingPos = character2;
        	}

        	else if(Mathf.Abs(cameraPosition.x - character3.x) < 125)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character3, 30);
                StartingPos = character3;
        	}

        	else if(Mathf.Abs(cameraPosition.x - character4.x) < 125 || cameraPosition.x > character4.x)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character4, 30);
                StartingPos = character4;
        	}

        	else
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character1, 30);
                StartingPos = character1;
        	}
        		
        }
    
    }

}
