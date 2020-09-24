using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float Delay = 2f;
    public GameObject completeLevelUI;
    public void levelcomplete()
    {

        Debug.Log("LEVEL WON");
        completeLevelUI.SetActive(true);

    }
    // Start is called before the first frame update
    public void gameover()
    {
        if (gameHasEnded == false) {

            gameHasEnded = true;
        Debug.Log(" GAME OVER ");
            Invoke("Restart", Delay);
    }
    }

     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
