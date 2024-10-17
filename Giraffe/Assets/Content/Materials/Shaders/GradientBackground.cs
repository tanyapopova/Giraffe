using UnityEngine;

namespace LightDev.Utils
{
  [ExecuteInEditMode]
  public class GradientBackground : MonoBehaviour
  {
    public bool parentToCamera;
    private Camera _camera;

    private void Awake()
    {
      SetupCamera();
    }

    private void Update()
    {
      if (_camera == null) SetupCamera();

      float distanceToCamera = _camera.farClipPlane * 0.95f;

      var frustumHeight = 2.0f * distanceToCamera * Mathf.Tan(_camera.fieldOfView * 0.5f * Mathf.Deg2Rad);
      var frustumWidth = frustumHeight * _camera.aspect;

      transform.localScale = new Vector3(frustumWidth, frustumHeight, 1);
      transform.localPosition = new Vector3(0, 0, distanceToCamera);
    }

    private void SetupCamera()
    {
      _camera = GetComponentInParent<Camera>();
      if (parentToCamera)
        transform.parent = _camera.transform;
    }
  }
}
