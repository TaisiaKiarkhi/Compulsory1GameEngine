using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rect_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float add_force = 25f;
    [SerializeField] GameObject Ball_;
    [SerializeField] Vector3 force;
    [SerializeField] int points;
    void Start()
    {
        //force = new Vector3(Ball_.GetComponent<Rigidbody>().velocity.x * add_force, 0, Ball_.GetComponent<Rigidbody>().velocity.z* add_force);
        force = new Vector3(0, 0, Ball_.GetComponent<Rigidbody>().transform.position.z * add_force);

        points = 20;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Ball_.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
        if(Ball_.transform.position.y > 4.0f)
        {
            Ball_.transform.position = new Vector3(Ball_.transform.position.x, 4.0f, Ball_.transform.position.z);
        }
        Ball_.GetComponent<Ball_Script>().score += points;

    }

}
