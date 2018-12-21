using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public GameObject explosionA;
    public GameObject fireA;
    public GameObject smokeA;

	// Use this for initialization
	void Start () {
        StartCoroutine(bakuhatuA());
        StartCoroutine(honoA());
        StartCoroutine(kemuriA());
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    IEnumerator bakuhatuA()
    {
        yield return new WaitForSeconds(1.0f);
        Instantiate(explosionA, new Vector3(0.9f * this.transform.localScale.x,
            this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

    }

    IEnumerator honoA()
    {
        yield return new WaitForSeconds(0.8f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x,
             0.7f*this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x-1.5f,
             0.7f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x - 3.0f,
             0.7f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x - 4.5f,
             0.7f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x - 6.0f,
             0.7f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(fireA, new Vector3(0.9f * this.transform.localScale.x - 7.5f,
             0.7f * this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }

    IEnumerator kemuriA()
    {
        yield return new WaitForSeconds(1.0f);
        Instantiate(smokeA, new Vector3(0.9f * this.transform.localScale.x,
        this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);
    }
}
