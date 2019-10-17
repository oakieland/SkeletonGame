using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
	private bool playerInZone;
	public string levelToLoad;
	
    // Start is called before the first frame update
    void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerInZone)
		{
			Application.LoadLevel(levelToLoad);
			//Application.LoadLevelAsync(levelToLoad);
		}
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{		
			// Player has reached the Zone
			playerInZone = true;
			GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
			
		}
	}
}
