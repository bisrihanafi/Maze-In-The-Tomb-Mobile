using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hapus : MonoBehaviour
{
    public GameObject ob;
    public GameObject ob2;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            Destroy(ob, timer);
            Destroy(ob2, timer);
        }

    }
}
