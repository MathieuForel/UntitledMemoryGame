using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChestOpenedCheck : MonoBehaviour
{
    public Transform ThisChest;
    public Sprite Chest;

    public AudioSource ComboDone;
    public AudioSource ComboFailed;
    public AudioSource ChestClose;

    public GameObject Canvas;

    public CameraShake cameraShake;

    public float time;
    public float delay;

    public int TimeResetMax;

    public int NumberOfChestOpen;
    public int RightChestOpen;

    public float Triple;
    public bool ChestReset = false;
    public bool TripleChestFound = false;
    public int TripleGotten;

    private void Update()
    {
        if(NumberOfChestOpen == 3)
        {
            time += 1 * Time.deltaTime;

            if(time > delay)
            {
                NumberOfChestOpen = 0;
                ChestTripleConnect();
                ChestOpen();
                ChestReset = false;
                TripleChestFound = false;
                RightChestOpen = 0;
                time = 0;
            }
        }

        if(TripleGotten == 5)
        {
            print("YOU WON");
            Canvas.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(cameraShake.Shake(0.25f, 0.025f));
        }

        if(TimeResetMax <= 0)
        {
            print("YOU LOSE");
            Canvas.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            StartCoroutine(cameraShake.Shake(0.25f, 0.025f));
        }

        Canvas.gameObject.transform.GetChild(2).GetComponent<Text>().text = "Attempts Left : " + TimeResetMax.ToString();
    }

    void ChestOpen()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            ThisChest = this.gameObject.transform.GetChild(i);

            if (ThisChest.gameObject.activeInHierarchy == true)
            {
                ChestOpenedCount(i);
            }
        }
    }

    void ChestOpenedCount(int i)
    {
        if (ThisChest.GetComponent<BoxCollider>().enabled == false)
        {
            if(ChestReset == true)
            {
                ThisChest.GetComponent<BoxCollider>().enabled = true;
                ThisChest.GetChild(1).gameObject.SetActive(false);

                ThisChest.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Chest;
                ThisChest.GetChild(0).GetComponent<Animator>().enabled = false;
                ChestClose.Play();
                StartCoroutine(cameraShake.Shake(0.15f, 0.15f));
            }

            if (TripleChestFound == true)
            {
                ThisChest.gameObject.SetActive(false);
            }
        }
    }

    void ChestTripleConnect()
    {
        Triple = RightChestOpen;
        Triple = Triple / 111;

        if (Mathf.Round(Triple) == Triple)
        {
            TripleChestFound = true;
            print("YOU GOT A TRIPLE");
            TripleGotten++;
            ComboDone.Play();
            StartCoroutine(cameraShake.Shake(0.1f, 0.25f));
        }
        else
        {
            ChestReset = true;
            print("YOU DIDNT GET A TRIPLE");
            TimeResetMax--;
            ComboFailed.Play();
        }
    }
}
