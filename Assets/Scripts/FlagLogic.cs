using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagLogic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Attackable"))
        {
            //End the game or remove one point?

            //other.gameObject.SetActive(false);
            
            other.gameObject.transform.position = new Vector3(0, 50, 0);
            //AudioSource.PlayClipAtPoint(sliceSound, transform.position);
        } else
        {
            other.gameObject.SetActive(true);
        }
    }


}
