using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStadiaChicken : Animal
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        CreateAnimalForm();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void CreateAnimalForm()
    {
        Instantiate(nextAnimal, transform.position, Quaternion.identity);
    }
}
