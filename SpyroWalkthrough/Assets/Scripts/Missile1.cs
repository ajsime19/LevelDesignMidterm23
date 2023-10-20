using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile1 : MonoBehaviour
{
    public float flightSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * flightSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Turret1 turret1 = collision.gameObject.GetComponentInParent<Turret1>();
            turret1.Damage(40f);
        }
        Destroy(gameObject);
    }
}
