using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartForce : MonoBehaviour
{
    public float force = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 forceVector = transform.forward * force;
        GetComponent<Rigidbody>().AddForce(forceVector);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
