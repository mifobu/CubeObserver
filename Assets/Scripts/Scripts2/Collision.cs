using UnityEngine;
namespace Chapter.Command{

public class Collision : MonoBehaviour
{
    public Movement movement;
    
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)  {
        if (collisionInfo.gameObject.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<Invoker>().Replay();
            //Debug.Log("based");
        }
    }
}
}