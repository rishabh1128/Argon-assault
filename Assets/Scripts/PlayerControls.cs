using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        float zOffset = horizontal * Time.deltaTime * speed;
        float yOffset = vertical * Time.deltaTime * speed;
        float zPos = transform.localPosition.z + zOffset; //horizontal
        float yPos = transform.localPosition.y + yOffset; //vertical
        transform.localPosition = new Vector3(
        transform.localPosition.x,
        yPos,
        zPos);
    }
}
