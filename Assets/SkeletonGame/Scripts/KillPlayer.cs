using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
	public LevelManager levelManager;
	public GameObject currentCheckpoint;
	public GameObject player;
	public GameObject breakEffect;
	public GameObject breakParticles;
	GameObject breakEffectClone;
	GameObject breakParticlesClone;
	
    // Start is called before the first frame update
    void Start()
    {
		//Looks for Level Manager Script
		levelManager = FindObjectOfType<LevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			// Respawn Player
			player.transform.position = currentCheckpoint.transform.position;
			
			// Play effect
			breakEffectClone = Instantiate(breakEffect, transform.position, transform.rotation);
			breakEffectClone.SetActive(true);
			
			//Optimize Effect after it's done
			Destroy(breakEffectClone,1);
			
			// Play effect
			breakParticlesClone = Instantiate(breakParticles, breakParticles.transform.position = player.transform.position, breakParticles.transform.rotation = player.transform.rotation);
			breakParticlesClone.SetActive(true);
			
			//Optimize Effect after it's done
			Destroy(breakParticlesClone,1);
			
			// Lose Money from Dying
			FindObjectOfType<GameManager>().AddGold(-10);
		}
	}
}
