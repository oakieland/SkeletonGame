using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float moveSpeed;
	public CharacterController controller;
	
	private Vector3 moveDirection;
	public float weight;
	
    // Start is called before the first frame update
    void Start()
    {
		controller = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
		moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0f, Input.GetAxis ("Vertical")*moveSpeed+8);

		
		//Gravity
		moveDirection.y = moveDirection.y + (Physics.gravity.y * weight);
		
		// Stabilizes Player Movement
		controller.Move(moveDirection * Time.deltaTime);
    }
	
}
