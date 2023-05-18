using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class hole : MonoBehaviour
{
    public UnityEvent OnballEnter = new UnityEvent();
    private void OnCollisionEnter(Collision other) {
        OnTriggerEnter(other.collider);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball"))
        {
            // Debug.Log("Ball enter");
            OnballEnter.Invoke();
        }
    }
}
