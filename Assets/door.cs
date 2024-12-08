using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Rigidbody rb; // 用于存储 Rigidbody 组件
    public float moveSpeed = 10f; // 设置物体的移动速度
    private float startTime; // 记录开始时间

    void Start()
    {
        // 获取 Rigidbody 组件
        rb = GetComponent<Rigidbody>();

        // 确保 Rigidbody 没有被设置为 isKinematic
        rb.isKinematic = false;

        // 确保物体没有被限制移动
        rb.constraints = RigidbodyConstraints.None; // 没有任何轴的限制

        // 设置 Rigidbody 为 Kinematic，禁用物理影响
        rb.isKinematic = true;

        // 可选：关闭重力影响
        rb.useGravity = false;

        // 记录游戏开始的时间
        startTime = Time.time;
    }

    void FixedUpdate()
    {
        // 判断当前时间是否已经超过 8 秒
        if (Time.time - startTime >= 8f)
        {
            // 计算物体的新位置，沿着 Z 轴向后移动
            Vector3 newPosition = transform.position + Vector3.back * moveSpeed * Time.fixedDeltaTime * 0.1f;

            // 使用 MovePosition 来平滑地移动物体
            rb.MovePosition(newPosition);

            // 调试信息，查看物体的当前坐标
            Debug.Log("Current Position: " + transform.position);
        }
    }
}
