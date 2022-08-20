using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : BasicEnemy
{

    public float shootDistance;
    public GameObject projectile;
    public float rateOfFire;
    public float lastShotTime;


    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) >= shootDistance)
        {
            MoveTowardsPlayer();
        }
        else
        {
            navAgent.destination = transform.position;
            if (lastShotTime + rateOfFire < Time.time)
            {
                ShootProjectile();
                lastShotTime = Time.time;
            }
        }
    }

    void ShootProjectile()
    {
        GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
        bullet.transform.LookAt(player.transform, Vector3.up);
    }

}
