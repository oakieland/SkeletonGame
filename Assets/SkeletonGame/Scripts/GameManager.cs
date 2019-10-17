using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	//# of Tips Gained
	public int currentGold;
	
	//Text Ui
	public Text goldText;
	
	void Start()
	{
		currentGold = PlayerPrefs.GetInt("PlayerGold");
		goldText.text = "" + currentGold;
	}
	

    // Update is called once per frame
    void Update()
    {
        if (currentGold == 0)
		{
			SceneManager.LoadScene("gameover");
		}
    }
	
	public void AddGold(int goldToAdd)
	{
		// Add Gold
		currentGold += goldToAdd;
		goldText.text = "" + currentGold;
		PlayerPrefs.SetInt("PlayerGold", currentGold);
	}
}
