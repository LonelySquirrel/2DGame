using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardAI : MonoBehaviour
{

    public List<Transform> wayPoints = new List<Transform>();
    private Transform targetWayPoint;
    private int targetWayPointIndex;
    private float minDistance = 0.1f;
    private int lastWayPointIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
