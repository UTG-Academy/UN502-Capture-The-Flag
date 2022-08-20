using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockProjectile : MonoBehaviour
{
    public float speed = 2f;
    public float impulseForce;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * impulseForce, ForceMode.Impulse);
            Destroy(gameObject);
        }
    }
}
