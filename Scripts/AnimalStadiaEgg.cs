using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStadiaEgg : Animal
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
}
