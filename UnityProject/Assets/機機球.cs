using UnityEngine;

public class 機機球 : MonoBehaviour {

    Rigidbody GG;
    float gogo;
    float inin;
    [Header("速度")]
    [Range(0,7)]
    public float speed ;
    [Header("跳躍")]
    [Range(0,7)]
    public float jumpfloat;
    Transform left;
    public bool isground;


    // Use this for initialization
    void Start ()
    {
        GG = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        /// <summary>
        /// 跑跑
        /// </summary>
        gogo = Input.GetAxis("Horizontal");
        inin = Input.GetAxis("Vertical");
        GG.AddForce(new Vector3(gogo * speed, 0));
        GG.AddForce(new Vector3(0,0, inin * speed));

        /// <summary>
        /// 跳跳
        /// </summary>

        if (Input.GetKeyDown(KeyCode.Space) && isground == true)

        {
            isground = false;
            jump();
        }
    }

    /// <summary>
    /// 判斷
    /// </summary>

    private void jump()
    {
        GG.AddForce(transform.up*100);
    }

    public void OnCollisionStay(Collision collision)
    {
        isground = true;
    }
}
