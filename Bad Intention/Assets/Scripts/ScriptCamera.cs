using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptCamera : MonoBehaviour
{

    private Vector3 dragOrigin;
    private Vector3 endOrigin;
    private Vector3 pos;
    private Vector3 cameraPosition;

    private Vector3 character1 = new Vector3(124, 390, -10);
    private Vector3 character2 = new Vector3(454, 307, -10);
    private Vector3 character3 = new Vector3(800, 390, -10);
    private Vector3 character4 = new Vector3(825, 246, -10);

    void Update ()
    {    
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);            

            if(touch.phase == TouchPhase.Began)
            {
                dragOrigin = touch.rawPosition;
                cameraPosition = this.transform.position;
                pos = new Vector3(0,0,0);
            }            

            if(touch.phase == TouchPhase.Moved)
            {
                endOrigin = touch.position;
            }

            if(touch.phase == TouchPhase.Ended)
            {
                pos = Camera.main.ScreenToViewportPoint(dragOrigin - endOrigin);
            }

        }     
                
        if(pos.x > 0.1) //swipe left
        {
            if(cameraPosition == character1)
                transform.position = Vector3.MoveTowards(this.transform.position, character2, 30);
            else if(cameraPosition == character2)
                transform.position = Vector3.MoveTowards(this.transform.position, character3, 30);
        }        
        else if(pos.x < -0.1) //swipe right
        {
            if(cameraPosition == character2)
                transform.position = Vector3.MoveTowards(this.transform.position, character1, 30);
            else if(cameraPosition == character3 || cameraPosition == character4)
                transform.position = Vector3.MoveTowards(this.transform.position, character2, 30);
        }
        else if(pos.y < -0.1) //swipe up
        {            
            if(cameraPosition == character1)
                transform.position = Vector3.MoveTowards(this.transform.position, character2, 30);
            else if(cameraPosition == character2 || cameraPosition == character3)
                transform.position = Vector3.MoveTowards(this.transform.position, character4, 30); 
        }
        else if(pos.y > 0.1) //swipe down
        {            
            if(cameraPosition == character2)
                transform.position = Vector3.MoveTowards(this.transform.position, character1, 30);
            else if(cameraPosition == character4)
                transform.position = Vector3.MoveTowards(this.transform.position, character3, 30); 
        }       
    
    }

}
