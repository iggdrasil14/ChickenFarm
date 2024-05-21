using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public float time;
    public Animal nextAnimal;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        CreateAnimalForm();
    }

    protected virtual void CreateAnimalForm()
    {
        Destroy(gameObject);
        Instantiate(nextAnimal, transform.position, Quaternion.identity);
    }
}
