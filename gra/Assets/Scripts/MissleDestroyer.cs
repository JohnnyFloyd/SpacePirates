using UnityEngine;
using System.Collections;

public class MissleDestroyer : MonoBehaviour {

	public float TimeToLive = 3.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		TimeToLive -= Time.deltaTime;
		if (TimeToLive < 0) {
			Destroy(gameObject);
		}
	}
}
