using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petunuk : MonoBehaviour
{
	Animator anim;
	Animator anim2;
    
    // Start is called before the first frame update
    void Start()
    {
		anim = GameObject.Find ("PetunukBoard").GetComponent<Animator> ();
		anim2 = GameObject.Find ("Pintu").GetComponent<Animator> ();
    }
	//PetunukBoard
	void OnTriggerEnter(Collider other) {
        anim2.SetBool("bukatutup", true);
		anim.SetBool("entered", true);

    }
	void OnTriggerExit(Collider other) {
		anim.SetBool("entered", false);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
