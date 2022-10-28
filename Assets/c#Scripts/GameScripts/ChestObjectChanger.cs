using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestObjectChanger : MonoBehaviour
{
    public int ItemNumber;

    public GameObject Particle0;
    public GameObject Particle1;
    public GameObject Particle2;
    public GameObject Particle3;
    public GameObject Particle4;
    public GameObject Particle5;

    public void ChestContenanceUpdate()
    {
        if(ItemNumber == 0)
        {
            var particle = Instantiate(Particle0, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }

        if(ItemNumber == 1)
        {
            var particle = Instantiate(Particle1, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }

        if(ItemNumber == 2)
        {
            var particle = Instantiate(Particle2, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }

        if(ItemNumber == 3)
        {
            var particle = Instantiate(Particle3, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }

        if(ItemNumber == 4)
        {
            var particle = Instantiate(Particle4, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }

        if(ItemNumber == 5)
        {
            var particle = Instantiate(Particle5, this.gameObject.transform.position, Quaternion.identity);
            particle.transform.parent = this.gameObject.transform;
        }
    }
}
