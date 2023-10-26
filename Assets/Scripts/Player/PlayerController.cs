using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerTeleport _teleport;
    [SerializeField] TimeController _timeController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Change static views
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _teleport.Next();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _teleport.Back();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _timeController.SetLight();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
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
    }
}
