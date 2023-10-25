using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    [SerializeField] CameraMove _camera;
    [SerializeField] Transform [] _teleportPoints;

    private int _teleportIndex;

    void Start()
    {
        _teleportIndex = 0;
        _camera.SetTransform(_teleportPoints[_teleportIndex]);
    }

    public void Next()
    {
        _teleportIndex = (_teleportIndex + 1) % _teleportPoints.Length;
        _camera.SetTransform(_teleportPoints[_teleportIndex]);
    }

    public void Back()
    {
        if (0 < _teleportIndex)
            _teleportIndex--;
        else
            _teleportIndex = _teleportPoints.Length - 1;
        _camera.SetTransform(_teleportPoints[_teleportIndex]);
    }
}
