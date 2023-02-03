using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPMovement : MonoBehaviour
{
    private MainPlayer _mainPlayer;
    private Rigidbody _rigidbody;
    private Transform _cameraTransform;

    private void Awake()
    {
        _mainPlayer = GetComponent<MainPlayer>();
        _rigidbody = GetComponent<Rigidbody>();
        _cameraTransform = Camera.main.transform;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector2 mpMoveInputValue = _mainPlayer.PlayerInput.MainPlayer.Move.ReadValue<Vector2> ();

        Vector3 velocity = new Vector3 (mpMoveInputValue.x, 0, mpMoveInputValue.y);
        velocity = _cameraTransform.TransformDirection (velocity);
        velocity.y = 0;
        velocity = velocity.normalized * _mainPlayer.MainPlayerAttributes.playerSpeed;
        _rigidbody.velocity = velocity;
    }
}
