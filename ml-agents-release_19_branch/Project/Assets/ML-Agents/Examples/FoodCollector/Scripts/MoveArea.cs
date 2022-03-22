using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{
    public FoodCollectorArea area;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = area.transform.position + new Vector3(Mathf.Sin(Time.time/5f)*30f, 1f, Mathf.Cos(Time.time/5f)*30f);
    }
}
