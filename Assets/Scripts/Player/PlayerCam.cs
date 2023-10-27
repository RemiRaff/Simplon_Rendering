using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] private float _sensX;
    [SerializeField] private float _sensY;

    [SerializeField] private CameraMove _cameraMove;

    private float _xRotation;
    private float _yRotation;

    public void MoveCamera(float inputX, float inputY)
    {
        float mouseX = inputX * Time.deltaTime * _sensX;
        float mouseY = inputY * Time.deltaTime * _sensY;
        _yRotation += mouseX;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);

        _cameraMove.SetTransform(transform);
    }
}
