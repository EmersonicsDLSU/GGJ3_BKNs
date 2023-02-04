using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MPLook : MonoBehaviour, IMPRefs
{
    [Tooltip ("Sensitivity for horizontal mouse input")]
    public float HorizontalMouseSensitivity = 0.4f;

    [Tooltip ("Sensitivity for vertical mouse input")]
    public float VerticalMouseSensitivity = 0.4f;

    [Tooltip("Maximum rotation for looking up and down")]
    public float MaxVerticalLook = 65.0f;

    [Tooltip("Acceleration when looking")]
    public float Acceleration = 8.5f;

    private bool _isMobile;

    private Vector2 _curLookInputValue;
    private float _curCameraXRotation;
    private float _curCameraYRotation;

    private void Start()
    {
        _isMobile = Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer;

        if (_isMobile)
        {
            StartMobile();
        }
        else
        {
            StartDesktop();
        }
    }

    private void StartMobile()
    {
        if (UnityEngine.InputSystem.Gyroscope.current != null)
        {
            InputSystem.EnableDevice(UnityEngine.InputSystem.Gyroscope.current);
        }
        if (AttitudeSensor.current != null)
        {
            InputSystem.EnableDevice(AttitudeSensor.current);
        }
    }

    private void StartDesktop()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void RefUpdate(MainPlayer mainRef)
    {
        if (_isMobile)
        {
            _curLookInputValue = UnityEngine.InputSystem.Gyroscope.current.angularVelocity.ReadValue();
        }

        UpdateLook(mainRef);
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        _curLookInputValue = ctx.ReadValue<Vector2>();
    }

    public void UpdateLook(MainPlayer mainRef)
    {
        Vector3 cameraRotation = mainRef.CameraTransform.eulerAngles;

        _curCameraXRotation -= _curLookInputValue.y * VerticalMouseSensitivity;
        _curCameraXRotation = Mathf.Clamp(_curCameraXRotation, -MaxVerticalLook, MaxVerticalLook);
        cameraRotation.x = _curCameraXRotation;

        _curCameraYRotation += _curLookInputValue.x * HorizontalMouseSensitivity;
        cameraRotation.y = _curCameraYRotation;

        Vector3 newCameraRotation = new Vector3(cameraRotation.x, mainRef.CameraTransform.eulerAngles.y, mainRef.CameraTransform.eulerAngles.z);
        Vector3 newTransformRotation = new Vector3(mainRef.transform.eulerAngles.x, cameraRotation.y, mainRef.transform.eulerAngles.z);

        mainRef.CameraTransform.rotation = Quaternion.Lerp(mainRef.CameraTransform.rotation, Quaternion.Euler(newCameraRotation), Time.deltaTime * Acceleration);
        if (mainRef.PlayerAnimController.CurrentState == ZombieStates.WALKING)
            mainRef.transform.rotation = Quaternion.Lerp(mainRef.transform.rotation, Quaternion.Euler(newTransformRotation), Time.deltaTime * Acceleration);
    }
}
