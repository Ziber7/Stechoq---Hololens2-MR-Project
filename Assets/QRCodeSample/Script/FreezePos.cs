using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePos : MonoBehaviour
{
    public MonoBehaviour Follow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(freeze());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator freeze()
    {
        yield return new WaitForSeconds(3f);
        Follow.enabled = false;
    }
}
