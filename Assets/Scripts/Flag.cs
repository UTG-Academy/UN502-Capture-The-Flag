using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    public bool captured;
    public float timeToCapture;
    public float timeSoFar;


    // Start is called before the first frame update
    void Start()
    {
        captured = false;
        timeSoFar = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSoFar > timeToCapture)
        {
            captured = true;
        }
    }


    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            timeSoFar += Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (!captured)
            {
                timeSoFar = 0;
            }
        }
    }


}
