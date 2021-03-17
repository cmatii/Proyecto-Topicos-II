using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

 public float Speed = 1.0f;
  public float RotationSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible= false;


        
    }

   

    // Update is called once per frame
    void Update()
    {
     
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0.0f, vertical)*Time.deltaTime*Speed);

        float rotationY = Input.GetAxis("Mouse X");
        
        transform.Rotate(new Vector3(0, rotationY*Time.deltaTime*RotationSpeed ,0 ));


    }
}
