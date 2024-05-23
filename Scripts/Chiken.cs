using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Chiken : MonoBehaviour
{
    //public Slider hungryStatus;
    //public Transform camera;
    public NavMeshAgent agent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

 

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = camera.position;
        //hungryStatus.transform.forward = direction;

        Food[] foods = FindObjectsOfType<Food>();
        Food targetFood = null;
        float minDistance = float.PositiveInfinity;
        foreach (var item in foods)
        {
            float distance = Vector3.Distance(transform.position, item.transform.position);
            if (minDistance > distance)
            {
                minDistance = distance;
                targetFood = item;
            }

        }

        if (targetFood == null)
        {
            return;
        }

        agent.SetDestination(targetFood.transform.position);
        //Не учитывается алгоритм, если еда за забором - курица не может пройти.
    }
}
