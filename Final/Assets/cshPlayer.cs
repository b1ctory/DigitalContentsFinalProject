using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayer : MonoBehaviour
{
    public float m_moveSpeed = 2.0f;

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = Vector3.right * h;
        Vector3 moveVertical = Vector3.forward * v;
        Vector3 velocity = (moveHorizontal + moveVertical).normalized;

        transform.LookAt(transform.position + velocity);

        transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World);
    }
}
