using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteractableScript : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private static readonly int Activated = Animator.StringToHash("Activated");
    [SerializeField] private float cooldown;
    private float timer = 0;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.ToLower().Contains("player"))
        {
            _animator.SetBool(Activated, true);
            timer = 0.0f;
        }
    }

    private void Update()
    {
        if (_animator.GetBool(Activated))
        {
            if (timer >= cooldown)
            {
                _animator.SetBool(Activated, false);
            }
            timer += Time.deltaTime;
        }
    }
}
