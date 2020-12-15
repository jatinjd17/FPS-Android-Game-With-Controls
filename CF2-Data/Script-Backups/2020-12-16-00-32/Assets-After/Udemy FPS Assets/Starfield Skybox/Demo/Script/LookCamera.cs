using UnityEngine;
using System.Collections;

public class LookCamera : MonoBehaviour 
{
    public float speedNormal = 10.0f;
    public float speedFast   = 50.0f;

    public float mouseSensitivityX = 5.0f;
	public float mouseSensitivityY = 5.0f;
    
	float rotY = 0.0f;
    
	void Start()
	{
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;
	}

	void Update()
	{	
        // rotation        
        if (ControlFreak2.CF2Input.GetMouseButton(1)) 
        {
            float rotX = transform.localEulerAngles.y + ControlFreak2.CF2Input.GetAxis("Mouse X") * mouseSensitivityX;
            rotY += ControlFreak2.CF2Input.GetAxis("Mouse Y") * mouseSensitivityY;
            rotY = Mathf.Clamp(rotY, -89.5f, 89.5f);
            transform.localEulerAngles = new Vector3(-rotY, rotX, 0.0f);
        }
		
		if (ControlFreak2.CF2Input.GetKey(KeyCode.U))
		{
			gameObject.transform.localPosition = new Vector3(0.0f, 3500.0f, 0.0f);
		}

	}
}
