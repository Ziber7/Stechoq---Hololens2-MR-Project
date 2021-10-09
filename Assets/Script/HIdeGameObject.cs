using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIdeGameObject : MonoBehaviour
{
    public GameObject object1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Sembunyikan()
    {
        StartCoroutine(DelaySeconds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelaySeconds()
    {
        yield return new WaitForSeconds(2);
        object1.SetActive(false);
    }
}
