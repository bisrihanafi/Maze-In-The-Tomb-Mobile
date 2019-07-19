using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnggleCameraFilm : MonoBehaviour
{
    public GameObject a, b, c;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IeTimeLeft());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator IeTimeLeft() {
        while (true) {
            a.SetActive(true);
            yield return new WaitForSeconds(delay);
            a.SetActive(false);
            b.SetActive(true);
            yield return new WaitForSeconds(delay);
            b.SetActive(false);
            c.SetActive(true);
            yield return new WaitForSeconds(delay);
            c.SetActive(false);


        }
    }
}
