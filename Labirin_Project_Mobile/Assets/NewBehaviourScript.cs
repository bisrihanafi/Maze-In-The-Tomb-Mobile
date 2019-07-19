using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	Animator anim1;
	Animator anim2;
	Animator anim3;
    // Start is called before the first frame update
    void Start()
    {
		anim1 = GameObject.Find ("Pintu1").GetComponent<Animator> ();
		anim2 = GameObject.Find ("Pintu2").GetComponent<Animator> ();
		anim3 = GameObject.Find ("Pintu3").GetComponent<Animator> ();
    }
	void OnTriggerEnter(Collider other) {
		anim1.SetBool("entered", true);
		anim2.SetBool("entered", true);
		anim3.SetBool("entered", true);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
