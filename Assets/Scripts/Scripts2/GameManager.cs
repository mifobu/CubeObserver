using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
      bool gameEnd = false;
      public GameObject completeLevelUI;

      public void EndGame(){
         if (gameEnd == false) {
            Debug.Log("GameOver");
            Invoke("Restart", 0);
         }
         gameEnd = true;
      }
      public void CompleteLevel () {
         Debug.Log("Win");
         completeLevelUI.SetActive(true);
      }
      void Restart() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
}
}