using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret1 : MonoBehaviour
{

    public float health = 100f;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(float damage)
    {
        health = health - damage;

        if (health <= 0)
        {
            camera.transform.SetParent(null);
            Destroy(gameObject);
        }
    }
}
