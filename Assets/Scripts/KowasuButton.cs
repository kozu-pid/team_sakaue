using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KowasuButton : MonoBehaviour
{

    public GameObject bakuhatu;

    // Use this for initialization
    void Start()
    {
        FadeManager.FadeIn();//フェードイン用 Staart()内に付け足す
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ThisButton()
    {

        this.gameObject.SetActive(false);
        Instantiate(bakuhatu, new Vector3(-1.4f, -2, -1.2f), Quaternion.identity);
        FadeManager.FadeOut(0);//行きたいシーンの番号
                               //FadeManager.FadeIn();
    }
}