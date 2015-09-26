using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    PlayerChildController whitePlayer, blackPlayer;
    public float jumpForce;
    // Use this for initialization
    void Start()
    {
        whitePlayer = GameObject.FindGameObjectWithTag("WhitePlayer").GetComponent<PlayerChildController>();
        blackPlayer = GameObject.FindGameObjectWithTag("BlackPlayer").GetComponent<PlayerChildController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            whitePlayer.Jump(jumpForce);
            blackPlayer.Jump(jumpForce);
        }
    }

    public void OnObstacleHit()
    {
        Camera.main.GetComponent<MoveCamera>().speed = 0;
    }
}
