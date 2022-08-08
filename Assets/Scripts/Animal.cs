using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
	protected Vector3 currentVelocity;

	protected float walkSpeed;
	protected float runSpeed;
	protected float jumpForce;
	
	protected float actionInterval;  //average time interval (in seconds) between actions

	protected float lifeInterval;  //time interval (in seconds) before self-destruction

	protected AudioSource voice;


	protected Animal()
	{
		walkSpeed = 2.0f;
		runSpeed = 3.0f * walkSpeed;
		jumpForce = 5.0f;

		actionInterval = 5.0f;
		lifeInterval = 20.0f;
	}


    void Start()
    {
		voice = GetComponent<AudioSource>();
		RandomAction();
    }


    void Update()
    {
		if (currentVelocity != Vector3.zero)
			gameObject.transform.position = gameObject.transform.position + Time.deltaTime * currentVelocity;
    }


	// ENCAPSULATION
	// ABSTRACTION
	public void Walk()
	{
		Debug.Log("Walk");
		currentVelocity = walkSpeed * RandomGroundDir();
	}

	// ENCAPSULATION
	// ABSTRACTION
	public void Run()
	{
		Debug.Log("Run");
		currentVelocity = runSpeed * RandomGroundDir();
	}

	public void Stop()
	{
		Debug.Log("Stop");
		currentVelocity = Vector3.zero;
	}


	public void Jump()
	{
		//TODO: jump
		Debug.Log("Jump");

	}


	protected virtual void Talk()
	{
		Debug.Log("Talk");
		voice.Play();
	}


	public void RandomAction() {
		int actionId = Random.Range(0, 5);

		switch (actionId) {
		case 0:
			Walk();
			break;
		case 1:
			Run();
			break;
		case 2:
			Stop();
			break;
		case 3:
			Jump();
			break;
		case 4:
			//Stop();
			Talk();
			break;
		default:
			break;
		}

		Invoke("RandomAction", actionInterval);
	}


	private Vector3 RandomGroundDir() {
		float xDir = Random.Range(0, 5.0f);
		float zDir = Random.Range(0, 5.0f);

		Vector3 res = new Vector3(xDir, 0, zDir);
		res.Normalize();

		return res;
	}
}
