using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTrriggerEnter(Collider other)
    {
        //add some code here that confers a benefit to the player

        Destroy(gameObject);
    }

}  