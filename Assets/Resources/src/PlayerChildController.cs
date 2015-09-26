using UnityEngine;
using System.Collections;

public class PlayerChildController : MonoBehaviour
{
    public string collisionLayer;
    public bool jumping = false;
    public int gravityVal = 1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(
            this.transform.position + -gravityVal * (this.transform.localScale / 2 + new Vector3(1, 0, 0)),
            new Vector2(0, -gravityVal),
            0.02f,
            LayerMask.GetMask(new string[] { collisionLayer }));
        jumping = (hit.transform == null 
            && GetComponent<Rigidbody2D>().velocity.y != 0);

    }

    public void Jump(float force)
    {
        if (!jumping && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            jumping = true;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, gravityVal * force), ForceMode2D.Impulse);
        }
    }
}
