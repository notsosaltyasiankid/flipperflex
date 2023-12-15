using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
private GameObject Ball;
public GameObject Teleport_exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball") {
            Ball = other.gameObject;
            other.gameObject.SetActive(false);
            StartCoroutine(WaitForTeleport());
        }
    }

    IEnumerator WaitForTeleport() {
        yield return new WaitForSeconds(0.4f);
        Ball.transform.position = Teleport_exit.transform.position;
        Ball.SetActive(true);
        
    }
}
