using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosoin4 : MonoBehaviour {

    public GameObject explosionD;
    public GameObject flameD;

	// Use this for initialization
	void Start () {
        StartCoroutine(bakuhatuD());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator bakuhatuD()
    {
        yield return new WaitForSeconds(1.0f);
        Instantiate(explosionD, new Vector3(0.9f * this.transform.localScale.x,
        this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
        yield return new WaitForSeconds(2.0f);
        Instantiate(flameD, new Vector3(0.5f * this.transform.localScale.x,
        this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);


    }
}
