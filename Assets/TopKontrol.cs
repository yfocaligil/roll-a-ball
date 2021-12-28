using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz;
    public TextMeshProUGUI skoryazisi,bitisyazisi;
    private int skor;
    
    
    void Start()
    {
        fizik=GetComponent<Rigidbody>();
        
      
   }

    
    void Update()
    {
         
          float yatay=Input.GetAxis("Horizontal");
          float  dikey=Input.GetAxis("Vertical");
          Vector3 vector=new Vector3(yatay*hiz,0,dikey*hiz);
         fizik.AddForce(vector);
         skoryazisi.text="SKOR:"+" "+skor;
    }
    private void OnTriggerEnter(Collider other) 
    {
        other.gameObject.SetActive(false);
        if(other.tag=="puan")
        {
           skor++; 
        }
    
     
        if(skor==7)
        {
            bitisyazisi.text="OYUN BİTTİ";
            
        }
    }
}
