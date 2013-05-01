using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	
	public Camera mainCamera;
	public GameObject misslePrefab;
	public Vector2 Y_Constraints = new Vector2(-10,10);
	public Vector2 X_Constraints = new Vector2(-10,10);
	public float speedZ = 3;
	public float speedXY = 20;
	public float fireSpeed = 30;
	public float fireDelta = 5.5f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		MoveShip();
		if ( Input.GetButtonUp("Fire1") ) {
			Shoot();
		}
	}

	void MoveShip ()
	{
		Vector3 pos = gameObject.transform.position;
		float newX = GetPositionConstrained(pos.x,Input.GetAxis("Horizontal"),X_Constraints);
		float newY = GetPositionConstrained(pos.y,Input.GetAxis("Vertical"),Y_Constraints);
		gameObject.transform.position = new Vector3(newX, newY, pos.z + speedZ*Time.deltaTime);
		mainCamera.transform.position = new Vector3(0,0,mainCamera.transform.position.z + speedZ*Time.deltaTime);
	}
	
	float GetPositionConstrained(float pos, float inputAxis, Vector2 constraints)
	{
		float temporary = pos + speedXY*inputAxis*Time.deltaTime;
		if (temporary < constraints.x) {
			return constraints.x;
		}
		else if (temporary > constraints.y) {
			return constraints.y;
		}
		else return temporary;	
	}
	
	void Shoot()
	{
		Vector3 pos = gameObject.transform.position;
		pos.Set(pos.x,pos.y,pos.z +fireDelta);
		GameObject missle =(GameObject) Instantiate(misslePrefab,pos,gameObject.transform.rotation);
		missle.rigidbody.AddForce(fireSpeed*Vector3.forward,ForceMode.Impulse);
	}	
}
