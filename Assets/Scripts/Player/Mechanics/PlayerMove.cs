using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    [SerializeField] private CameraMove _cameraMove;

    public void Move(float x, float z)
    {
        Vector3 direction = _cameraMove.transform.forward * z + _cameraMove.transform.right * x;
        _cameraMove.transform.Translate(direction.normalized * Time.deltaTime * _moveSpeed);
    }
}
