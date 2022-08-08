using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
	public Cat() {
		walkSpeed = 1.0f;
		runSpeed = 5 * walkSpeed;
		jumpForce = 10.0f;

		actionInterval = 3;
		lifeInterval = 45;
	}


	protected override void Talk()
	{
		Debug.Log("Cat talks!");
	}
}
