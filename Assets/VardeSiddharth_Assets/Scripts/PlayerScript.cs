using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerScript : MonoBehaviourPun
{
    [SerializeField]
    float playerMoveSpeed = 5f;

    float VerticalInput;
    void Start()
    {
        if(photonView.IsMine)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(photonView.IsMine)
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        VerticalInput = Input.GetAxis("Vertical");

        transform.position += (transform.up * playerMoveSpeed * Time.deltaTime * VerticalInput); 

        if(transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 6, transform.position.z);
        }

        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4, transform.position.z);
        }
    }
}
