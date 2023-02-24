using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic3 : MonoBehaviour
{
    public Vector3 catapultLaunch = new Vector3(100.0f, 100.0f, 100.0f);
    public Vector3 start = new Vector3(0, 33, 0);
    bool catapultFired = false;

    int time = 200;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {

        time -= 1;

        if (time < 0)
        {

            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().gameObject.transform.position = start;
            catapultFired = false;
            time = 200;
        }


        if (!catapultFired)
        {
            GetComponent<Rigidbody>().AddForce(catapultLaunch, ForceMode.Impulse);
            catapultFired = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.gameObject.CompareTag("Nothing"))
        {
            
            //other.gameObject.transform.position = new Vector3(0, 50, 0);
            //AudioSource.PlayClipAtPoint(sliceSound, transform.position);
        } else
        {
            other.gameObject.SetActive(true);
        }
        */
    }

}
