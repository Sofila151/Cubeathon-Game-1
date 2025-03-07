using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject completeLeverUI;

    public void CompleteLevel ()
    {
       completeLeverUI.SetActive(true);
    }

  public void EndGame ()
  {
    if (gameHasEnded == false)
    {
        gameHasEnded = true;
        Debug.Log("Game Over");
        Invoke("Restart", restartDelay);
    }
  }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
