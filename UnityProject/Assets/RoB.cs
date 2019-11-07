using UnityEngine;

public class RoB : MonoBehaviour
{


    [Header("速度"), Range(0f, 1000f)]
    public float speed = 50f;
    [Header("跳躍"), Range(0f, 1000f)]
    public float jump = 100f;
    [Header("是否在地上")]
    public bool IsGround = false;

    private Rigidbody r2d;



    // Use this for initialization
    private void Start()
    {
        r2d = GetComponent<Rigidbody>();

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGround = true;
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        //向前
        if (Input.GetKey(KeyCode.W))
        { transform.Translate(0, 0, speed * 0.1f * Time.deltaTime); }
        //向後
        if (Input.GetKey(KeyCode.S))
        { transform.Translate(0, 0, speed * -0.1f * Time.deltaTime); }
        //向右
        if (Input.GetKey(KeyCode.D))
        { transform.Translate(speed * 0.1f * Time.deltaTime,0,  0); }
        //向左
        if (Input.GetKey(KeyCode.A))
        { transform.Translate(speed * -0.1f * Time.deltaTime,0, 0); }
    }


    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && IsGround == true)
        {
            r2d.AddForce(new Vector3(0, jump,0));
            IsGround = false;
        }
    }
}