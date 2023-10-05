using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad_2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotation_deg = -35f;
    [SerializeField] Vector3 rotat;
    [SerializeField] float speed = 50f;
    bool pressed = false;
    [SerializeField] GameObject ball_;


    void Start()
    {
        rotat = new Vector3(0, 0, rotation_deg);
    }
    // Update is called once per frame
    void Update()
    {
        pad_rotate();
    }

    void pad_rotate()
    {
        Debug.Log("the rotation fucntion works");
        if (Input.GetKeyDown(KeyCode.D) && pressed == false)
        {
            transform.Rotate(rotat, Space.Self);
            pressed = true;
        }

        else if (Input.GetKeyDown(KeyCode.D) && pressed == true)
        {
            transform.Rotate(new Vector3(0, 0, -rotation_deg), Space.Self);
            pressed = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        ball_.GetComponent<Rigidbody>().AddForce(Vector3.right * speed, ForceMode.Impulse);
        ball_.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }

}