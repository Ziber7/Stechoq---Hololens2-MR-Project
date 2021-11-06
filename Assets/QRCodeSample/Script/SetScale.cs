using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = new Vector3 (0.03f , 0.03f , 0.03f);
        StartCoroutine(wait());
    }



    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3 (0.03f , 0.03f , 0.03f);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.01f);
       // transform.localScale = new Vector3 (0.03f , 0.03f , 0.03f);
    }
}
