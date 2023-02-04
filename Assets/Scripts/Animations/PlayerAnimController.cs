using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    // Property with set values for playing certain animation 
    public ZombieStates CurrentState
    {
        set
        {
            _currentState = value;

            switch (_currentState)
            {
                case ZombieStates.IDLE:
                    _animator.Play("Idle");
                    break;
                case ZombieStates.WALKING:
                    _animator.Play("Walk");
                    break;
                case ZombieStates.ATTACK:
                    _animator.Play("Attack");
                    break;
                case ZombieStates.FLEX:
                    _animator.Play("Flex");
                    break;
                case ZombieStates.DEATH:
                    _animator.Play("Death");
                    break;
                default:
                    Debug.LogWarning($"{name} doesn't contain a {value} animation!");
                    break;
            }
        }
    }
    private ZombieStates _currentState;
    
    // Attributes


    // Components
    [HideInInspector] public Animator _animator;
    [HideInInspector] public PlayerAnimation _playerAnimation;
    
    void Start()
    {
        // Initialize components
        _animator = GetComponent<Animator>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }
    
    void Update()
    {

    }

    public void FireAttackAnim()
    {
        _playerAnimation.AttackAnim(this);
    }
}
