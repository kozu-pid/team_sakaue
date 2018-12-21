using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion2 : MonoBehaviour {

    public GameObject explosionB;
    public GameObject sparkB;

	// Use this for initialization
	void Start () {
        StartCoroutine(bakuhatuB());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator bakuhatuB()
    {
        yield return new WaitForSeconds(1.0f);
        Instantiate(explosionB, new Vector3(0.8f * this.transform.localScale.x,
           0.8f*this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
        yield return new WaitForSeconds(2.0f);
        Instantiate(sparkB, new Vector3(0.7f * this.transform.localScale.x,
           0.8f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }

   
}
