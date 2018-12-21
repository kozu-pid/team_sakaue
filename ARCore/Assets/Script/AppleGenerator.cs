using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour {

    [SerializeField] GameObject applePrefab;
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            GameObject apple = Instantiate(applePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            apple.GetComponent<BombController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
