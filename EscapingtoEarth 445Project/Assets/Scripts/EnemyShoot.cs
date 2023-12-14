using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    private float timer;
    [SerializeField]
    private float RandChance;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        RandChance = Random.Range(10, 100);
    }

    // Update is called once per frame
    void Update()
    {
        RandChance = Random.Range(10, 100);
        timer += Time.deltaTime;

        if(timer > 4){
            timer = 0;
            if (RandChance > 10)
            {
                shoot();
            }
        }
        void shoot(){
            Instantiate (bullet, bulletPos.position,Quaternion.identity);
        }

    }
}
