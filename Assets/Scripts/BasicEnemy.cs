using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BasicEnemy : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public GameObject player;
    public float impulseForce;


    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }

    // Update is called once per frame
    void Update()
    {

        MoveTowardsPlayer();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<Rigidbody>().AddForce(transform.forward * impulseForce, ForceMode.Impulse);
        }
    }

    public void SetupVariables()
    {
        navAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        impulseForce = 15;
    }

    public void MoveTowardsPlayer()
    {
        navAgent.destination = player.transform.position;
    }



}
