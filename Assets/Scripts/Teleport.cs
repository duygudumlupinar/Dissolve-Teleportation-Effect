using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform OtherPortal;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Dissolve>().isDissolving = true;
        StartCoroutine(Reappear(other));
    }

    IEnumerator Reappear(Collider other)
    {
        yield return new WaitForSeconds(1);
        other.transform.position = OtherPortal.position;
        other.gameObject.GetComponent<Dissolve>().isDissolving = false;
    }
}
