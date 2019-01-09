using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

    [SerializeField] GameObject normalUI;
    [SerializeField] GameObject pauseUI;

	// Use this for initialization
	void Start () {
        normalUI.SetActive(true);
        pauseUI.SetActive(false);
	}
	
    public void PauseButtonDown(){
        normalUI.SetActive(false);
        pauseUI.SetActive(true);
        //時間を止める
        Time.timeScale = 0f;
    }

    public void ContinueButtonDown(){
        normalUI.SetActive(true);
        pauseUI.SetActive(false);
        //時間を進める
        Time.timeScale = 1f;
    }

    public void DestroyButtonDown(){
        //現在あるオブジェクトを綺麗にする

    }
    public void ExitButtonDown(){
        Application.Quit();
    }
}
