using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public float startYValue = 20;
    public float endYValue = -20;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < endYValue)
        {
            Vector3 startPos = Vector3.zero;
            startPos.y = startYValue;
            startPos.x = Random.Range(-10, +10);
            transform.position = startPos;
            rb.velocity = Vector3.zero;
        }
    }
}
