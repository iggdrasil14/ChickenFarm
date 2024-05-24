using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStadiaChicken : MovingAnimal
{  
    public override IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            CreateAnimalForm();
        }
        
    }

    protected override void CreateAnimalForm()
    {
        Instantiate(nextAnimal, transform.position, Quaternion.identity);
    }
}
