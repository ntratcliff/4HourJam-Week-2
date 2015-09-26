using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    PlayerChildController whitePlayer, blackPlayer;
    public float jumpForce;
    public float restartDelay;
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
        whitePlayer.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        blackPlayer.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        StartCoroutine(RestartGame(restartDelay));
    }

    public IEnumerator RestartGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        Application.LoadLevel(0); //restart level
    }
}
