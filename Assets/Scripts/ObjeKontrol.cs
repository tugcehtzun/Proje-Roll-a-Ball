using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vekt�r = new Vector3(15, 30, 45);

        transform.Rotate(vekt�r*0.01f);
    }
}
