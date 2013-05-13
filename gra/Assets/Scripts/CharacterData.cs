using UnityEngine;
using System.Collections;

public class CharacterData : MonoBehaviour {
	
	private int level;
	private int experiencePoints;
	private int stamina;
	private	int attack;
	private int progressPoints;
	private float regeneration;
	private float reload;
	
	// Use this for initialization
	void Start () {
		level = 1;
		experiencePoints = 0;
		stamina = 30;
		attack = 5;
		progressPoints = 0;
		regeneration = 0;
		reload = 1;
	}
	
	void AddExperiencePoints(int points)
	{
		experiencePoints += points;
		if (expriencePoint > 1000) { //Threshold
			level++;
			addProgressPoints();
		}
	}

	void addProgressPoints ()
	{
		throw new System.NotImplementedException ();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
