using UnityEngine;
using UnityEngine.SceneManagement;
public class loadlevel : MonoBehaviour
{
public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
