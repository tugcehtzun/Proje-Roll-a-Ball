using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject Top;
    public Vector3 aradakiFark;

    // Start is called before the first frame update
    void Start()
    {
        aradakiFark = transform.position - Top.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Top.transform.position + aradakiFark;
        
    }
}
