using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
        public float speed;
    [SerializeField]
    private bool DevChaseActive;

    private float distance;
    void Start()
    {
        DevChaseActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyDetection();
    }
   
    private void Chase()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
 
     void EnemyDetection()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out RaycastHit hitinfo, 10f) || Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hitinfo, 10f))
        {
            Debug.Log("Hit something");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitinfo.distance, Color.red);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hitinfo.distance, Color.red);
            if (DevChaseActive)
            {
                Chase();
            }
        }
        else
        {
            Debug.Log("Nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 10f, Color.green);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 10f, Color.green);
        }
    }
}
