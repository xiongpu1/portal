using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f; // �����ƶ��ٶ�
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ��ȡ Rigidbody ���
    }

    void Update()
    {
        // ��ȡ WASD ����
        float moveX = Input.GetAxis("Horizontal"); // A/D �� ��/�Ҽ�ͷ
        float moveZ = Input.GetAxis("Vertical");   // W/S �� ��/�¼�ͷ

        // ������������ƶ�����
        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized * moveSpeed * Time.deltaTime;

        // ʹ�� Rigidbody �� MovePosition �����������λ��
        rb.MovePosition(transform.position + movement);
    }

}
