using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowObs : MonoBehaviour
{

    Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        if (collider)
        {
            collider.isTrigger = true;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Nyawa berkurang 1");
        }
    }
}
