using UnityEngine;

public class Collision : MonoBehaviour
{
    public movement movement;
  

     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().gameover();
            
        }
    }


}
