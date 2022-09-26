using UnityEngine;

namespace Chapter.Observer
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeController _bikeController;
        
        void Start()
        {
            _bikeController = 
                (BikeController) 
                FindObjectOfType(typeof(BikeController));
        }
        
        void OnGUI()
        {
            if (GUILayout.Button("-1 life"))
                if (_bikeController) 
                    _bikeController.TakeDamage(1.0f);
        }
    }
}