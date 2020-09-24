using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 500f;
    public float sidewayforce = 100f;
    public float jumpforce =5f;

    // Start is called before the sfirst frame update
    void Start()
    {
            }

    // Update is called once per frame
    //Use FixedUpdate for physics

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        //Hold d to move right
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        //Hold a to move left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce * Time.deltaTime,0,  0,ForceMode.VelocityChange);
        }
        
        if (rb.position.y <0f)
        {
            FindObjectOfType<GameManager>().gameover();
        }
    }
}
