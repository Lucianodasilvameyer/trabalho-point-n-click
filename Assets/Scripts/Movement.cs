using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10.0f;
    [SerializeField]
    float dashForce = 30f;

    private Rigidbody m_Rigidbody;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * movementSpeed;// * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movementSpeed;// * Time.deltaTime;

        DoMovement(x, y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash(x, y);
        }
    }

    void DoMovement(float h, float v)
    {
        Vector3 direction = new Vector3(h, 0, v);

        m_Rigidbody.velocity = direction;        
    }

    void Dash(float h, float v)
    {
        Vector3 direction = new Vector3(h, 0, v);

        m_Rigidbody.AddForce(direction * dashForce, ForceMode.Impulse);

        //m_Rigidbody.velocity = direction * dashForce;
    }
}
