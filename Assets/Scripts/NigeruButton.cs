using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NigeruButton : MonoBehaviour {

    public GameObject bakuhatu;

	// Use this for initialization
	void Start () {
        FadeManager.FadeIn();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ThisButton(){

        this.gameObject.SetActive(false);
        Instantiate(bakuhatu, new Vector3(1.3f, -2, -1.2f), Quaternion.identity);
        FadeManager.FadeOut(0);//行きたいシーンの番号
    }
}
