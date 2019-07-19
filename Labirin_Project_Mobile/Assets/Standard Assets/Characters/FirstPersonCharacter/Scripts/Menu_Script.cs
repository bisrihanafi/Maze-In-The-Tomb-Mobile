using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    Animator anim;
    bool tombolstat;
    
    void Start()
    {
        anim = panel.GetComponent<Animator>();
        tombolstat = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BukaMenu() {
        if (tombolstat)
        {
            anim.SetBool("buka", false);
            tombolstat = false;
        }
        else if (tombolstat == false) {
            anim.SetBool("buka", true);
            tombolstat = true;
        }
    }
    
    
}
