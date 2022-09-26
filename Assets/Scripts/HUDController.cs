using UnityEngine;

namespace Chapter.Observer {
    public class HUDController : Observer {
        private float _currentLives = 3;
        private BikeController _bikeController;
        
        void OnGUI() {
            GUILayout.BeginArea (
                new Rect (50,50,100,200));
           
            if (true) {
                GUILayout.BeginHorizontal("box");
                GUILayout.Label("");
                GUILayout.Label("Lives: " + _currentLives);
                //GUILayout.Label("WARNING: Low Health");
                GUILayout.EndHorizontal();
            }            
            GUILayout.EndArea ();
        }

        public override void Notify(Subject subject) {
            if (!_bikeController)
                _bikeController = 
                    subject.GetComponent<BikeController>();
            
            if (_bikeController) {
                
                _currentLives = 
                    _bikeController.CurrentLives;
            }
        }
    }
}