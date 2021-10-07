using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemTest : MonoBehaviour
{

    public ParticleSystem ps;
    private Renderer rend; 

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("OnCollisionEnter.");
        rend.enabled = false; 
        // Do something
        ps.Emit(500); 
    }
}
