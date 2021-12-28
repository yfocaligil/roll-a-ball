using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerataki : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakifark;
    void Start()
    {
        aradakifark=transform.position-top.transform.position;
        
    }

    
    void Update()
    {
        transform.position=top.transform.position+aradakifark;
    
    }
}
