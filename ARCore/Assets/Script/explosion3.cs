using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion3 : MonoBehaviour {

    public GameObject explosionC;
    public GameObject flameC;
    public GameObject smokeC;

	// Use this for initialization
	void Start () {
        StartCoroutine(bakuhatuC());
       // StartCoroutine(honoC());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator bakuhatuC()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(explosionC, new Vector3(0,
           1.1f*this.transform.localScale.y, -3f), Quaternion.identity);

        yield return new WaitForSeconds(0.1f);
        Instantiate(smokeC, new Vector3(0,
           0.8f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(1.5f);
        Instantiate(flameC, new Vector3(0,
           0.8f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }

    IEnumerator honoC()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(flameC, new Vector3(0,
           0.8f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }

    IEnumerator kemuri()
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(smokeC, new Vector3(0,
           0.8f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }
}


