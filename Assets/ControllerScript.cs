using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    private Animator myAnimator;
    // Start is called before the first frame update
	
	
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetFloat ("VSpeed", Input.GetAxis ("Vertical")); 
		myAnimator.SetFloat("HSpeed",  Input.GetAxis("Horizontal"));
		
		if(Input.GetButtonDown ("Jump")){ 
		myAnimator.SetBool ("Jumping", true);
		Invoke ("StopJumping", 0.1f);
			}
			
		if(Input.GetKey("q")) {
			if((Input.GetAxis ("Vertical") == 0f) && (Input.GetAxis ("Horizontal") == 0)){
				transform.Rotate (Vector3.down * Time.deltaTime * 100.0f);

				myAnimator.SetBool ("TurningLeft", true);
			}
				} else {
				myAnimator.SetBool ("TurningLeft", false);
			}
	
		if(Input.GetKey("e")){
			if((Input.GetAxis ("Vertical") == 0f) && (Input.GetAxis ("Horizontal") == 0)){
				transform.Rotate (Vector3.up * Time.deltaTime * 100.0f);
				myAnimator.SetBool ("TurningRight", true);
			}
				} else {
			myAnimator.SetBool ("TurningRight", false);
			}
	

    }
			void StopJumping(){
		myAnimator.SetBool ("Jumping", false);
			}
}