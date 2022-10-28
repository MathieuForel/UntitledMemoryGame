using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    public Color ImageColor;

    private void Start()
    {
        ImageColor = this.gameObject.GetComponent<Image>().color;
    }
    void Update()
    {
        ImageColor.a -= 0.3f * Time.deltaTime;

        this.gameObject.GetComponent<Image>().color = ImageColor;

        if(ImageColor.a <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
