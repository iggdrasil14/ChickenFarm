using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject chikenFood;       //Префаб еды.
    public Transform foodCoordinates;   //Точка появления префаба "еда".


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Луч
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 200))
            {
                Vector3 foodCoordinates = hit.point;
                GameObject food = Instantiate(chikenFood, foodCoordinates, Quaternion.identity);
                Debug.Log("Hit " + hit.transform.name);
                Debug.Log(hit.point);
            }
        }    
    }
}
