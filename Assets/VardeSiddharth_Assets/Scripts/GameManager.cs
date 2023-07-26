using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject playerPrefab;
    [SerializeField]
    GameObject ballPrefab;

    static GameObject ballObject;

    // Start is called before the first frame update
    void Start()
    {
        if(ballObject == null)
        {
            ballObject = PhotonNetwork.Instantiate(ballPrefab.name, Vector3.zero, Quaternion.identity);
        }

        if(PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, Vector3.right * -5.5f, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(playerPrefab.name, Vector3.right * 5.5f, Quaternion.identity);
        }
    }
}
