using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoldText : MonoBehaviour
{
    FoodCollectorAgent agent;
    TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponentInParent<FoodCollectorAgent>();
        text = GetComponentInParent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(-Camera.main.transform.position);
        text.text = agent.score.ToString();
    }
}
