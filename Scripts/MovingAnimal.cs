using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum State 
{ 
    None,
    Idle,
    Walk
}
public abstract class MovingAnimal : Animal
{
    public Animator animator;
    public NavMeshAgent agent;
    public float speed;
    public float delay;
    private float timer;
    public State state;

    private void Awake()
    {
        agent.speed = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            state = State.Idle;
            timer = delay;
            Destroy(other.gameObject);
        }
    }

    public void Update()
    {
        switch (state)
        {
            case State.Idle:
                IdleProcess();
                break;
            case State.Walk:
                WalkProcess();
                break;
        }
    }

    private void IdleProcess()
    {
        animator.SetFloat("State", 0);
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            state = State.Walk;
        }
    }

    private void WalkProcess()
    {
        animator.SetFloat("State", 1);
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
            state = State.Idle;
            return;
        }

        agent.SetDestination(targetFood.transform.position);
        //Не учитывается алгоритм, если еда за забором - курица не может пройти.
    }

}
