using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerTeleport _teleport;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _teleport.Next();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _teleport.Back();
        }
    }
}
