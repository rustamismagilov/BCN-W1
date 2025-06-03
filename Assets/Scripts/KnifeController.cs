using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        //rotation
        transform.Rotate(0, 0, -steerAmount);

        //y-axis movement
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);

        float clampedX = Mathf.Clamp(transform.position.x, -6.3f, 6.3f);
        float clampedY = Mathf.Clamp(transform.position.y, -4.2f, 4.2f);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);


    }



}
