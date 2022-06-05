using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    public Rigidbody fizik;
    public int puan;
    public int objeSayisi;
    public Text puanText;
    public Text oyunBittiText;
   // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        //transform.Translate(0, 0, -10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vectör = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vectör*hiz);

        Debug.Log(transform.position);
        //Debug.Log(yatay);
        //Debug.Log(dikey); 

        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;

        puanText.text = "Puan: " + puan;

        if (puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }

        
        
    }




}
        

    

