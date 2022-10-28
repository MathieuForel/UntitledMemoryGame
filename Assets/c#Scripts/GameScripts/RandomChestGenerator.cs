using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChestGenerator : MonoBehaviour
{
    public Transform _transform;

    public int NumberOfChilds;
    public int RandomNumber;
    public int ParticleChosen;

    public int[] ArrayParticleNumber = {3, 3, 3, 3, 3, 1};
    public ArrayList ArrayParticleLeft = new ArrayList();

    public void Awake()
    {

        _transform = this.gameObject.transform;
    }

    public void Start()
    {
        NumberOfChilds = this.gameObject.transform.childCount;


        ArrayParticleLeft.Add(0);
        ArrayParticleLeft.Add(1);
        ArrayParticleLeft.Add(2);
        ArrayParticleLeft.Add(3);
        ArrayParticleLeft.Add(4);
        ArrayParticleLeft.Add(5);

        for (int i = 0; i < this.NumberOfChilds; i++)
        {
            Randomizer();
            NumberOfObjectCheck();

            _transform.GetChild(i).GetComponent<ChestObjectChanger>().ItemNumber = ParticleChosen;
            _transform.GetChild(i).GetComponent<ChestObjectChanger>().ChestContenanceUpdate();
        }

    }

    public void Randomizer()
    {
        RandomNumber = Random.Range(0, ArrayParticleLeft.Count);

        ParticleChosen = int.Parse(ArrayParticleLeft[RandomNumber].ToString());
    }

    public void NumberOfObjectCheck()
    {

        if (ParticleChosen == 5)
        {
            Randomizer();
        }

        ArrayParticleNumber[ParticleChosen]--;


        if (ArrayParticleNumber[ParticleChosen] == 0)
        {
            ArrayParticleLeft.Remove(ParticleChosen);
        }


        /*
        print("Random Number : " + RandomNumber);
        print("Particle Chosen : " + ParticleChosen);
        print("Number of that particle : " + ArrayParticleNumber[ParticleChosen]);
        print("Number of particle left : " + ArrayParticleLeft.Count);
        print("----------------------------------------------------");
        */


    }
}
