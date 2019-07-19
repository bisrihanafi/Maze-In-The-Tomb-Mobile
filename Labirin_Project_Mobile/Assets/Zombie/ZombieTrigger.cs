using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{
    public GameObject zombie;
    Animator anim;
    public float delay;
    public GameObject DeathPanel;
    // Start is called before the first frame update
    void Start()
    {

        anim = zombie.GetComponent<Animator>();
        //StartCoroutine(IeTimeLeft());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="FPSController")
        {
            anim.SetBool("entered", true);
            DeathPanel.SetActive(true);
            //Destroy(DeathPanel, .5f);
        }
        if (other.name == "Batas1" || other.name == "Batas2") {
            anim.SetBool("balik", true);
            transform.Rotate(0,180,0);
        }
        //anim.SetBool("entered",true);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("entered", false);
        anim.SetBool("balik", false);
    }
    //IEnumerator IeTimeLeft() {
       // while (true) {
        //    yield return new WaitForSeconds(delay);
        //    transform.Rotate(0,180,0);
            
       // }
    //}
}
