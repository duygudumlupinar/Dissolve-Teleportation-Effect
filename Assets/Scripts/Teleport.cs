using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform OtherPortal;

    private void OnTriggerEnter(Collider other)
    {
        OtherPortal.gameObject.GetComponent<Collider>().enabled = false;
        GetComponent<Collider>().enabled = false;
        StartCoroutine(Reappear(other));
    }

    IEnumerator Reappear(Collider other)
    {
        yield return new WaitForSeconds(2);
        other.gameObject.GetComponent<Dissolve>().isDissolving = !other.gameObject.GetComponent<Dissolve>().isDissolving;
        other.transform.position = OtherPortal.position;
    }

    IEnumerator ColliderSet()
    {
        yield return new WaitForSeconds(2);
        OtherPortal.gameObject.GetComponent<Collider>().enabled = true;
        GetComponent<Collider>().enabled = true;
    }
}
