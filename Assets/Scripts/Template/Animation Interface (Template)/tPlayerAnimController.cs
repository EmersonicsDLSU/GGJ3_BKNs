using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class tPlayerAnimController : MonoBehaviour
{
    // Property with set values for playing certain animation 
    public HumanStates CurrentState
    {
        set
        {
            _currentState = value;

            switch (_currentState)
            {
                case HumanStates.IDLE:
                    _animator.Play("Idle");
                    break;
                case HumanStates.WALK:
                    _animator.Play("Walk");
                    break;
                default:
                    Debug.LogWarning($"{name} doesn't contain a {value} animation!");
                    break;
            }
        }
    }
    private HumanStates _currentState;
    
    // Attributes
    public float fMoveSpeed = 1.0f;
    public Vector2 _moveInput = Vector2.zero;

    // Components
    [HideInInspector] public Animator _animator;
    private Rigidbody _rb;
    private SpriteRenderer _spriteRenderer;
    private tPlayerAnimation _tPlayerAnimation;
    
    void Start()
    {
        // Initialize components
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _tPlayerAnimation = GetComponent<tPlayerAnimation>();
    }
    
    bool isWalk = false;
    void FixedUpdate()
    {
        // persistent update of movement
        //_rb.velocity = _moveInput * fMoveSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isWalk = !isWalk;
            if (isWalk) _tPlayerAnimation.WalkAnim(this);
            else _tPlayerAnimation.IdleAnim(this);
        }
    }
    /*
    // the current scene should have a playerInput
    void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>();

        if (_moveInput != Vector2.zero)
        {
            _tPlayerAnimation.WalkAnim(this);

            // Set facing left or right
            if (_moveInput.x > 0)
            {
                _spriteRenderer.flipX = false;
            }
            else if (_moveInput.x < 0)
            {
                _spriteRenderer.flipX = true;

            }
        }
        else
        {
            _tPlayerAnimation.IdleAnim(this);
        }
    
        */
}
