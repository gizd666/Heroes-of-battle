using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {
	public int streanght;
	public int perception;
	public int endurance;
	public int charisma;
	public int inteligence;
	public int agility;
	public int luck;
	public int hp;
	public int ap;
	public int fieldOfView;
	public int carryWeight;
	public int armor;
	public int closeDamage;
	public int critChance;
	public int critDmg;
	public int closeRange;
	public int exp;
	public int level;



	// Use this for initialization
	void Start () {
		streanght = 5;
		perception = 5;
		endurance = 5;
		endurance = 5;
		charisma = 5;
		inteligence = 5;
		agility = 500;
		luck = 5;
		level = 2;

		hp = (streanght + (2 * endurance)) * 10 + level * 2;
		ap = agility + 2;
		fieldOfView = perception * 2;
		armor = agility + luck;
		closeDamage = streanght * 2 + endurance;
		critChance = luck;
		critDmg = 50;
		closeRange = 2;



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
