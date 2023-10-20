using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform firePoint;
    public Missile missilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            Fire();
        }
    }

    public void Fire()
    {
        Missile missile = Instantiate(missilePrefab);
        missile.transform.position = firePoint.position;
        missile.transform.rotation = firePoint.rotation;
    }
}
