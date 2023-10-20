using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController1 : MonoBehaviour
{
    //public float health = 100f;
    //public Camera camera;

    [Header("Movement")]
    public float moveSpeed = 5f;
    public float moveInput = 0f;

    [Header("Rotation")]
    public float rotSpeed = 180f;
    public float rotInput = 0f;

    [Header("Turret")]
    public Transform turret;
    public float turretSpeed = 180f;
    public float turretInput = 0f;

    [Header("Barrel")]
    private Vector3 barrelEuler;
    public float barrelMin = -30f;
    public float barrelMax = 10f;

    public Transform barrel;
    public float barrelSpeed = 90f;
    public float barrelInput = 0f;

   // public Transform pivot;
    public Transform player;
    public float threshDist = 20;
    public float distance;
    public Transform firePoint;
    public Missile missilePrefab;

    public float cooldown = 5f;
    public float nextShotTime = float.MinValue;


    // Start is called before the first frame update
    void Start()
    {
        barrelEuler = barrel.localEulerAngles;
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Vertical");
        transform.Translate(moveInput * Vector3.forward * Time.deltaTime * moveSpeed);

        rotInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotInput * rotSpeed * Time.deltaTime);

        turretInput = Input.GetAxis("Mouse X");
        turret.Rotate(Vector3.up, turretInput * turretSpeed * Time.deltaTime);

        barrelInput = Input.GetAxis("Mouse ScrollWheel");
        barrelEuler.x = Mathf.Clamp(barrelEuler.x + barrelInput * barrelSpeed * Time.deltaTime, barrelMin, barrelMax);
        barrel.localEulerAngles = barrelEuler;


        distance = Vector3.Distance(transform.position, player.position);

        if(Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }
    public void Fire()
    {
        Missile missile = Instantiate(missilePrefab);
        missile.transform.position = firePoint.position;
        missile.transform.rotation = firePoint.rotation;

        //nextShotTime = Time.time + cooldown;
    }
}
