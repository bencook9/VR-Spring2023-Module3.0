using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    public Vector3 catapultLaunch = new Vector3(-10.0f, 10.0f, 0.0f);
    bool catapultFired = false;


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
