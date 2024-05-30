using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public FoodManager foodManager;
    public GameObject chikenFood;       //������ ���.
    public Transform foodCoordinates;   //����� ��������� ������� "���".


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //���
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 200) && foodManager.food > 0)
            {
                Vector3 foodCoordinates = hit.point;
                GameObject food = Instantiate(chikenFood, foodCoordinates, Quaternion.identity);
                Debug.Log("Hit " + hit.transform.name);
                Debug.Log(hit.point);
                foodManager.SpendFood();
            }
        }    
    }
}
