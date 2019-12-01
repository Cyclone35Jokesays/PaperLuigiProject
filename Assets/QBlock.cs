using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBlock : MonoBehaviour
{
    public GameObject qBlock;
    public GameObject unQBlock;

    public bool activate;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            qBlock.SetActive(false);
            unQBlock.SetActive(true);
            transform.GetComponent<Collider>().isTrigger = true;
        }
    }
}
