using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleButton : MonoBehaviour {

    public GameObject bakuhatu;
   

	
     void Start () {
        FadeManager.FadeIn();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonApple(){

        GameObject texture = GameObject.Find("bakuhatsu");

        this.gameObject.SetActive(false);
        texture.SetActive(false);

        Instantiate(bakuhatu, new Vector3(0, 0, -1.2f), Quaternion.identity);
        Instantiate(bakuhatu, new Vector3(0, 0, -1.2f), Quaternion.identity);
        Instantiate(bakuhatu, new Vector3(0, 0, -1.2f), Quaternion.identity);
        Instantiate(bakuhatu, new Vector3(0, 0, -1.2f), Quaternion.identity);


        FadeManager.FadeOut(1);//行きたいシーンの番号


    }

 
}
