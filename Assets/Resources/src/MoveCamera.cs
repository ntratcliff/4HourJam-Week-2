using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed, 0, 0);
    }
}
