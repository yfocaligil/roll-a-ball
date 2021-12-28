using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puanhareket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector=new Vector3(0.1f,0.1f,0.1f);
        transform.Rotate(vector);
    }
}
