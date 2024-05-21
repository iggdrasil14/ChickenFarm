using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chiken : MonoBehaviour
{
    
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
