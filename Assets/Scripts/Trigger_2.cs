using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_2: MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float add_force = 15f;
    [SerializeField] GameObject Ball_;
    [SerializeField] Vector3 force;
    [SerializeField] int points;
    void Start()
    {
        force = new Vector3(Ball_.transform.position.x * add_force, 0, Ball_.transform.position.z * add_force);
        points = 20;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        Ball_.GetComponent<Rigidbody>().AddForce(Vector3.forward*add_force, ForceMode.Impulse);
        Ball_.GetComponent<Rigidbody>().AddForce(Vector3.right * add_force, ForceMode.Impulse);

        Ball_.GetComponent<Ball_Script>().score += points;

    }
}

