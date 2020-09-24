
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter()
    {
        manager.levelcomplete();
    }
}
