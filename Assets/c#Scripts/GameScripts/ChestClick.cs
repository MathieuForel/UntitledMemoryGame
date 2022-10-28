using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestClick : MonoBehaviour
{
     public GameObject ChestManager;
     public CameraShake cameraShake;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ChestManager.GetComponent<ChestOpenedCheck>().NumberOfChestOpen < 3)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                hit.transform.GetComponent<BoxCollider>().enabled = false;

                hit.transform.GetChild(1).gameObject.SetActive(true);

                ChestManager.GetComponent<ChestOpenedCheck>().NumberOfChestOpen += 1;

                if(hit.transform.GetComponent<ChestObjectChanger>().ItemNumber == 5)
                {
                    ChestManager.GetComponent<ChestOpenedCheck>().NumberOfChestOpen = 3;
                }

                ChestManager.GetComponent<ChestOpenedCheck>().RightChestOpen = (ChestManager.GetComponent<ChestOpenedCheck>().RightChestOpen * 10) + hit.transform.GetComponent<ChestObjectChanger>().ItemNumber + 1;

                Debug.Log(hit.transform.name);
                Debug.Log("hit");


                hit.transform.GetChild(0).GetComponent<Animator>().enabled = true;

                StartCoroutine(cameraShake.Shake(0.05f, 0.1f));
            }
        }
    }
}
