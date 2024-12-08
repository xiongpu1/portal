using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Rigidbody rb; // ���ڴ洢 Rigidbody ���
    public float moveSpeed = 10f; // ����������ƶ��ٶ�
    private float startTime; // ��¼��ʼʱ��

    void Start()
    {
        // ��ȡ Rigidbody ���
        rb = GetComponent<Rigidbody>();

        // ȷ�� Rigidbody û�б�����Ϊ isKinematic
        rb.isKinematic = false;

        // ȷ������û�б������ƶ�
        rb.constraints = RigidbodyConstraints.None; // û���κ��������

        // ���� Rigidbody Ϊ Kinematic����������Ӱ��
        rb.isKinematic = true;

        // ��ѡ���ر�����Ӱ��
        rb.useGravity = false;

        // ��¼��Ϸ��ʼ��ʱ��
        startTime = Time.time;
    }

    void FixedUpdate()
    {
        // �жϵ�ǰʱ���Ƿ��Ѿ����� 8 ��
        if (Time.time - startTime >= 8f)
        {
            // �����������λ�ã����� Z ������ƶ�
            Vector3 newPosition = transform.position + Vector3.back * moveSpeed * Time.fixedDeltaTime * 0.1f;

            // ʹ�� MovePosition ��ƽ�����ƶ�����
            rb.MovePosition(newPosition);

            // ������Ϣ���鿴����ĵ�ǰ����
            Debug.Log("Current Position: " + transform.position);
        }
    }
}
