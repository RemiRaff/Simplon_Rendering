using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTransform(Transform t)
    {
        gameObject.transform.position = t.position;
        gameObject.transform.rotation = t.rotation;
    }
}
