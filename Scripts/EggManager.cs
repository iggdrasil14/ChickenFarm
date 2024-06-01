using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggManager : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public GameObject eggPrefab;

    public void CreateEgg()
    {
        GameObject Egg = Instantiate(eggPrefab, GetRandomPoint(), Quaternion.identity);
    }
    
    public Vector3 GetRandomPoint()
    {
        Vector3 point = Vector3.zero;
        point.x = Random.Range(point1.position.x, point2.position.x);
        point.y = point1.position.y;
        point.z = Random.Range(point1.position.z, point2.position.z);
        return point;
    }
}
