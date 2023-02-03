using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MPLook : MonoBehaviour
{
    [Tooltip ("Sensitivity for horizontal mouse input")]
    [SerializeField] public float HorizontalMouseSensitivity = 2.0f;
    
    [Tooltip ("Sensitivity for vertical mouse input")]
    [SerializeField] public float VerticalMouseSensitivity = 2.0f;

    private const float MaxCameraXRotation = 85.0f;

    private MainPlayer _mainPlayer;
    private Transform _cameraTransform;

    private float _curCameraXRotation;
    private float _curCameraYRotation;

    private void Awake()
    {
        _mainPlayer = GetComponent<MainPlayer> ();
        _cameraTransform = Camera.main.transform;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        _curCameraXRotation = _cameraTransform.eulerAngles.x;
        _curCameraYRotation = _cameraTransform.eulerAngles.y;
    }

    private void Update()
    {
        Vector2 mpLookInputValue = _mainPlayer.PlayerInput.MainPlayer.Look.ReadValue<Vector2> ();

        Vector3 cameraRotation = _cameraTransform.eulerAngles;

        _curCameraXRotation -= mpLookInputValue.y * VerticalMouseSensitivity;
        _curCameraXRotation = Mathf.Clamp (_curCameraXRotation, -MaxCameraXRotation, MaxCameraXRotation);
        cameraRotation.x = _curCameraXRotation;

        _curCameraYRotation += mpLookInputValue.x * HorizontalMouseSensitivity;
        cameraRotation.y = _curCameraYRotation;

        _cameraTransform.eulerAngles = cameraRotation;
    }
}
