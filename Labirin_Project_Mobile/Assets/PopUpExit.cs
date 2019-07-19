using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PopUpExit : MonoBehaviour
{
	Animator anim;
    public GameObject panelA;
    public GameObject panelB;
    GameObject ui;
    bool x=false;
    // Start is called before the first frame update
    void Start()
    {
		anim = GameObject.Find ("PanelExit").GetComponent<Animator> ();
        ui = GameObject.Find("UI");
    }
	void OnTriggerEnter(Collider other) {
		anim.SetBool("entered", true);
        
    }
	void OnTriggerExit(Collider other) {
		anim.SetBool("entered", false);
	}
	
    // Update is called once per frame
    void Update()
    {
        //x=anim.GetBool("entered");
        //Application.LoadLevel("ExtraScane");
        
    }
    public void SwicthAtoB() {
        panelA.SetActive(false);
        panelB.SetActive(true);
        ui.SetActive(false);
    }
    public void ExitWorld() {
        Application.LoadLevel("ExtraScane");
    }
    public void RestartPlay()
    {
        Application.LoadLevel("SampleScene");
    }
    public void BackToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
