using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float bulletSpeed = 10;
    [field: SerializeField]
    public Bullet bullet { get; private set; }

    HeroCharacterController heroCharacterController;
    [SerializeField]

    Transform bulletFirePosition;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        heroCharacterController = GetComponent<HeroCharacterController>();
    }

    void Fire()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition.z = -cam.transform.position.z;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        Vector3 mousePos = new Vector3(mouseposition.x, mouseposition.y, 0);
        Vector3 instantitePos = new Vector3(bulletFirePosition.position.x, bulletFirePosition.position.y, 0);
        Quaternion bulletRot = Quaternion.LookRotation(instantitePos + (mousePos - instantitePos), transform.up);
        Bullet bulletClone = (Bullet)Instantiate(bullet, instantitePos, Quaternion.identity);
        bulletClone.transform.LookAt(instantitePos + (mousePos - instantitePos));
        int bulletDirection = ((heroCharacterController.horizontalInput >= 0) ? 1 : -1);
        bulletClone.currentPos = bulletFirePosition.position;

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();

    }

}
