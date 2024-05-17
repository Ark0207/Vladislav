﻿using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public EnemySpawner mySpawner;
	public int enemies;
	public int waves ;
	public int winwave = 3;
	public GameObject cutscene;

	// Use this for initialization
	protected void Start() {
		enemies = Random.Range(waves * 2, waves * 4);

	}



	public void SpawnWave()
	{
		for (int i = 0; i < enemies; i++)
		{
			mySpawner.Invoke("Spawn", i);
		}



	}

	// Update is called once per frame
	protected void Update()


	
	{
		if (waves > winwave)
		{
			mySpawner.gameObject.SetActive(false);
			cutscene.SetActive(true);
			return;
		}
		if (EnemySpawner.activated && mySpawner.transform.childCount == 0 && !IsInvoking())
		{


			waves++;
			HUD.Message("round nr" +  waves);
			enemies = Random.Range(waves * 2, waves * 4);
			SpawnWave();
		}
	
	}   

}      