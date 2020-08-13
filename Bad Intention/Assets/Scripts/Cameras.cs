using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cameras : MonoBehaviour
{

    private Vector3 dragOrigin;
    private Vector3 endOrigin;
    private Vector3 pos = new Vector3(0,0,0);
    private Vector3 cameraPosition;
    private Vector3 tempCameraPosition;

    bool isReadyToMove = false;

    private Vector3 character1 = new Vector3(124, 355, -10);
    private Vector3 character2 = new Vector3(370, 353, -10);
    private Vector3 character3 = new Vector3(621, 362, -10);
    private Vector3 character4 = new Vector3(825, 350, -10);

    void Update ()
    {    
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            isReadyToMove = false;
            tempCameraPosition = this.transform.position;
            if(tempCameraPosition == character1 || tempCameraPosition == character2 ||
                tempCameraPosition == character3 || tempCameraPosition == character4)
            {
                isReadyToMove = true;
            }
                      
            if(touch.phase == TouchPhase.Began && isReadyToMove)
            {
                pos = new Vector3(0,0,0);
                cameraPosition = this.transform.position;
                dragOrigin = touch.rawPosition;                    
            }            

            if(touch.phase == TouchPhase.Moved && isReadyToMove)
            {
                endOrigin = touch.position;
            }

            if(touch.phase == TouchPhase.Ended && isReadyToMove)
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
