using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion5 : MonoBehaviour {

    public GameObject explosionE;
    public GameObject smokeE;
    public GameObject flameE;

	// Use this for initialization
	void Start () {
        StartCoroutine(bakuhatuE());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator bakuhatuE()
    {
        yield return new WaitForSeconds(1.0f);
        
        Instantiate(explosionE, new Vector3(0,
           1, -2.6f), Quaternion.identity);

        Instantiate(smokeE, new Vector3(0.9f * this.transform.localScale.x,
      this.transform.localScale.y, this.transform.localScale.z), Quaternion.identity);

        yield return new WaitForSeconds(1.5f);
        Instantiate(flameE, new Vector3(0,
     1, -2.6f), Quaternion.identity);

    }
}
