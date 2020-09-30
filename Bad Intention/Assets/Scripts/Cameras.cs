using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cameras : MonoBehaviour
{
    private Vector3 dragOrigin;
    private Vector3 endOrigin;
    private Vector3 pos;
    private Vector3 cameraPosition;

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
            	endOrigin = touch.position;
            	cameraPosition = this.transform.position;

            	float lerpValueX = Mathf.Lerp(dragOrigin.x, endOrigin.x, (Time.time-2.0f)*0.2f);
    			float lerpValueY = Mathf.Lerp(dragOrigin.y, endOrigin.y, (Time.time-2.0f)*0.2f);
   				transform.position = new Vector3(lerpValueX, lerpValueY, -10);

   				/*if(cameraPosition.x >= 110 && cameraPosition.x <= 839) //within the max horizontal boundary
            	{
            		pos = Camera.main.ScreenToViewportPoint(dragOrigin - endOrigin);
            		endOrigin.z = -10;
    				transform.Translate(endOrigin, Space.World); 
    				transform.position = Vector3.MoveTowards(this.transform.position, endOrigin, 30);
    
            	}*/

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
        	}

        	else if(Mathf.Abs(cameraPosition.x - character2.x) < 125)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character2, 30);
        	}

        	else if(Mathf.Abs(cameraPosition.x - character3.x) < 125)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character3, 30);
        	}

        	else if(Mathf.Abs(cameraPosition.x - character4.x) < 125 || cameraPosition.x > character4.x)
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character4, 30);
        	}

        	else
        	{
        		transform.position = Vector3.MoveTowards(this.transform.position, character1, 30);
        	}
        		
        }
    
    }

}
