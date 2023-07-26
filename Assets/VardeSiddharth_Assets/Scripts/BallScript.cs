using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    float ballSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce((Vector3.up * Random.Range(-1f, 1f) * ballSpeed) + 
            (Vector3.right * Random.Range(-1f, 1f) * ballSpeed),
            ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
