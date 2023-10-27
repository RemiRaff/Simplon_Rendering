using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerTeleport _teleport;
    [SerializeField] TimeController _timeController;

    [SerializeField] PlayerCam _playerCam;

    [SerializeField] PlayerMove _playerMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Change static views
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _teleport.Next();
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            _teleport.Back();
        }
        // Change day/night
        if (Input.GetKeyDown(KeyCode.Home))
        {
            _timeController.SetLight();
        }
        if (Input.GetKeyDown(KeyCode.End))
        {
            _timeController.SetNight();
        }
        // Start/Stop time, day/night cycle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_timeController.IsRunning())
                _timeController.StopTime();
            else
                _timeController.StartTime();
        }
        // mouse button locks cursor
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        // in cursor locked, player controls camera with mouse/keyboard
        if (!Cursor.visible)
        {
            // mouse controls camera rotation
            _playerCam.MoveCamera(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            // keyboards controls camera moving
            _playerMove.Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
}
