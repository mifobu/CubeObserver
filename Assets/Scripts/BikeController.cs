using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Observer
{
    public class BikeController : Subject
    {

        public float CurrentLives
        {
            get { return lives; } 
            
        }

        private HUDController _hudController;
        [SerializeField] private float lives = 1.0f;
        
        void Awake()
        {
            _hudController = 
                gameObject.AddComponent<HUDController>();
        }


        void OnEnable()
        {
            if (_hudController) 
                Attach(_hudController);
        }
        
        void OnDisable()
        {
            if (_hudController) 
                Detach(_hudController);
            
        }

        
        public void TakeDamage(float amount)
        {
            lives -= amount;
            
            NotifyObservers();
            
            if (lives == 0)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}