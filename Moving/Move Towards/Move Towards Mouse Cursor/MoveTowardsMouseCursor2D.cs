using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMouseCursor2D : MonoBehaviour
{
    //Projectile is type that is later thrown from center
    public GameObject projectile;
    private Stack<GameObject> projectiles;
    private Vector2 spawnSource;
    private float power;

    void Start()
    {
        //Remember to set all the values required!
        spawnSource = new Vector2(0, 0);
        power = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        //In this example move sequence is triggered by mouse 0 click
        if (Input.GetMouseButtonDown(0))
        {
            GameObject projectileInstance = Instantiate(projectile, spawnSource, Quaternion.identity) as GameObject;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float projectileX = mousePosition.x - spawnSource.x;
            float projectileY = mousePosition.y - spawnSource.y;
            float r = Mathf.Sqrt(projectileX * projectileX + projectileY * projectileY);
            Vector2 projectileThrow = new Vector2(projectileX / r, projectileY / r);
            projectileInstance.GetComponent<Rigidbody2D>().AddForce(projectileThrow * power);
            projectiles.Push(projectileInstance);
        }
    }
}
