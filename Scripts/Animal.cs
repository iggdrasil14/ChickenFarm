using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public float time;
    public Animal nextAnimal;
    public ParticleSystem FlashExplosionRadial;

    // Start is called before the first frame update
    public virtual IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        CreateAnimalForm();
    }

    protected virtual void CreateAnimalForm()
    {
        Destroy(gameObject);
        Instantiate(FlashExplosionRadial, transform.position, Quaternion.identity);
        Instantiate(nextAnimal, transform.position, Quaternion.identity);
    }
}
