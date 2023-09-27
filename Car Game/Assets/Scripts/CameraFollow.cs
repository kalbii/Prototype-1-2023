using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0.0f, 0.77f, -2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z - 2);
        transform.position = Player.transform.position + offset;
        //transform.rotation = new Vector3(transform.rotation.x, Player.transform.rotation.y, transform.rotation.z);
    }
}
