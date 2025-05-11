using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LogAnimation : MonoBehaviour
{
    public float duration = 2;
    public Ease ease = Ease.Linear;
    void Start()
    {
        transform.DOMoveX(-1, duration).SetEase(ease);
    }

    void Update()
    {
        
    }
}
