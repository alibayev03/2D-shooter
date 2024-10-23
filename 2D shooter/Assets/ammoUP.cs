using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{

    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Проверяем, что столкнулись с игроком
        {
            other.GetComponent<ShootingController>().fireRate= 0.02f;
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
