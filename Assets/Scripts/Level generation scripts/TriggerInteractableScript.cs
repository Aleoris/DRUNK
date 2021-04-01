using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteractableScript : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int Activated = Animator.StringToHash("Activated");

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.ToLower().Contains("player"))
        {
            _animator.SetTrigger(Activated);
        }
    }
}
