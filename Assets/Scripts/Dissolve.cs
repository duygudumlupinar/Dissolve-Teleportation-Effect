using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dissolve : MonoBehaviour
{
    [SerializeField] private Material material;

    public float dissolveAmount;
    public bool isDissolving;

    void Update()
    {
        if (isDissolving)
        {
            dissolveAmount = Mathf.Clamp01( dissolveAmount + Time.deltaTime);
            material.SetFloat("_DissolveAmount", dissolveAmount);
        }
        else
        {
            dissolveAmount = Mathf.Clamp01(dissolveAmount - Time.deltaTime);
            material.SetFloat("_DissolveAmount", dissolveAmount);
        }

    }

    public void DissolveStarter()
    {
        isDissolving = true;
    }
    public void DissolveStopper()
    {
        isDissolving = false;
    }
}
