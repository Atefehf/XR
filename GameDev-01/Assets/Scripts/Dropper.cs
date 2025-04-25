using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mrenderer;
    Rigidbody rigidBogy;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        mrenderer = GetComponent<MeshRenderer>();
        rigidBogy = GetComponent<Rigidbody>();

            mrenderer.enabled = false;
            rigidBogy.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait){
            GetComponent<Renderer>().enabled = true;
            rigidBogy.useGravity = true;

        }
    }
}
