using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour
{
	public int value;
	public GameObject pickupEffect;
	public GameObject pickupSound;
	GameObject pickupEffectClone;
	GameObject pickupSoundClone;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			// Add Value/Points to Player
			FindObjectOfType<GameManager>().AddGold(value);
			
			// Play effect
			pickupEffectClone = Instantiate(pickupEffect, transform.position, transform.rotation);
			pickupEffectClone.SetActive(true);
		    
			//Optimize Effect after it's done
			Destroy(pickupEffectClone,1);
			
			// Play effect
			pickupSoundClone = Instantiate(pickupSound, transform.position, transform.rotation);
			pickupSoundClone.SetActive(true);
			
			//Optimize Effect after it's done
			Destroy(pickupSoundClone,1);
			
			//Destroy the tip
			Destroy(gameObject);
			
		}
	}
}
