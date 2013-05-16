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
	
	private static int[] expThreshold;
	private static int MAX_LEVEL = 13;
	
	// Use this for initialization
	void Start () {
		level = 1;
		experiencePoints = 0;
		stamina = 30;
		attack = 5;
		progressPoints = 0;
		regeneration = 0;
		reload = 1;
		
		expThreshold = new int[MAX_LEVEL + 1];
		expThreshold[1] = 1000;
		for (int i = 2; i < MAX_LEVEL + 1; i++) {
			expThreshold[i] = expThreshold[i-1] + (i-1)*2000;
		}
	}
	
	void AddExperiencePoints(int points)
	{
		experiencePoints += points;
		if (experiencePoints > expThreshold[level]) 
		{
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
