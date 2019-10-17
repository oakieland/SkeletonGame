using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public string selectLevel;
	
    // Start is called before the first frame update
	public void PlayGame()
	{
		
		SceneManager.LoadScene(selectLevel);
		PlayerPrefs.SetInt("PlayerGold", 40);
	}
	
}
