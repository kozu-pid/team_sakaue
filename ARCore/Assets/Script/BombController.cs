using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

    [SerializeField] GameObject[] BombParticle;
    [SerializeField] GameObject[] fireParticle;

    [SerializeField] float DestroyInterval;
    [SerializeField] float FireGeneratetime;

    [SerializeField] int BombParticleNumber;
    [SerializeField] int FireParticleNumber;

    private GameObject particle;

    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;

        particle = Instantiate(BombParticle[BombParticleNumber]) as GameObject;
        Vector3 pos = transform.position;
        particle.transform.position = pos;
        StartCoroutine(FireGenerate());
        StartCoroutine(ExecuteBomb());
    }

    IEnumerator ExecuteBomb()
    {
        yield return new WaitForSeconds(DestroyInterval);
        Destroy(this.gameObject);

    }

    IEnumerator FireGenerate(){
        yield return new WaitForSeconds(FireGeneratetime);
        GameObject fire = Instantiate(fireParticle[FireParticleNumber]) as GameObject;
        Vector3 pos = transform.position;
        fire.transform.position = pos;
        Destroy(particle);
    }

    // Use this for initialization
    void Start () {
        //Shoot(new Vector3(0, 200, 2000));
	}
	

	// Update is called once per frame
	void Update () {
		
	}
}
