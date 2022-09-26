using UnityEngine;

namespace Chapter.Command
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private CubeController _cubeController;
        private Command _buttonA, _buttonD;
        private GameManager _gameManager;
        
        void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _cubeController = FindObjectOfType<CubeController>();

            _buttonA = new TurnLeft(_cubeController);
            _buttonD = new TurnRight(_cubeController);

            _cubeController.ResetPosition();
            _isReplaying = false;
            _isRecording = true;
            _invoker.Record();

            
           
            
        }

        void Update()
        {
            if (!_isReplaying && _isRecording)
            {
                if (Input.GetKeyUp(KeyCode.A)) 
                    _invoker.ExecuteCommand(_buttonA);
                
                if (Input.GetKeyUp(KeyCode.D)) 
                    _invoker.ExecuteCommand(_buttonD);
            }

        }
        
        void OnGUI()
        {
            
            /*if (GUILayout.Button("Stop Recording"))
            {
                _cubeController.ResetPosition();
                _isRecording = false;
            }
            if (GUILayout.Button("Start Replay"))
                {
                    _cubeController.ResetPosition();
                    _isRecording = false;
                    _isReplaying = true;
                    _invoker.Replay();
                }
*/
        }
    }
}