using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundPlayer : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler
{
    public AudioSource source;
    public AudioSource source2;

    public void OnPointerEnter(PointerEventData eventData)
    {
        source.Play();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        source2.Play();
    }
}
