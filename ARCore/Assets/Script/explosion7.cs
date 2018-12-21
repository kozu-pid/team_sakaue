using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion7 : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(baku());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator baku()
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(obj1, new Vector3(0,
     0.5f * this.transform.localScale.y, -2.5f), Quaternion.identity);

        Instantiate(obj2, new Vector3(0.3f * this.transform.localScale.x,
0.5f * this.transform.localScale.y, -2.5f), Quaternion.identity);

        yield return new WaitForSeconds(2.0f);
        Instantiate(obj3, new Vector3(0,
1, -2.5f), Quaternion.identity);

    }
}