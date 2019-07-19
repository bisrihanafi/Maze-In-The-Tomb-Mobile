using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
	public float timer;
	public GameObject ObjectDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (timer >=0)timer -= Time.deltaTime;
		if(timer < 0)
		{
			Destroy(ObjectDestroy,0);
		}
    }
    public void Destroy()
    {
         Destroy(ObjectDestroy, 0);
    }
}
