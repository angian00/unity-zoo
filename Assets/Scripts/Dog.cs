using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
	public Dog() {
		walkSpeed = 2.0f;
		runSpeed = 2.5f * walkSpeed;
		jumpForce = 5.0f;

		actionInterval = 7;
		lifeInterval = 25;
	}

	protected override void Talk()
	{
		Debug.Log("Dog talks!");
	}
}
