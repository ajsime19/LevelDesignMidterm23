using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
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
        if(collision.gameObject.tag == "Enemy")
        {
            //TankController tankcontroller = collision.gameObject.GetComponentInParent<TankController>();
            //tankcontroller.Damage(40f);

            Ice ice = collision.gameObject.GetComponentInParent<Ice>();
            ice.Damage(100f);
        }
        Destroy(gameObject);
    }
}
