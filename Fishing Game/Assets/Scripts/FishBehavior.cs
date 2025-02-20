using UnityEngine;

public class FishBehavior : MonoBehaviour
{
    public GameObject hook;

    public int stage = 0;

    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var fishspeed = 3.0f;//Random.Range(1.0f, 6.5f);
        switch (stage)
        {
            case 0:
                transform.Translate(Vector3.right * fishspeed * Time.deltaTime);
                if (transform.position.x > 12)
                {
                    Destroy(gameObject);
                }
                break;
            case 1:
                transform.Translate(Vector3.up * speed * Time.deltaTime * 2);
                if (transform.position.y > 3.1)
                {
                    Destroy(gameObject);
                    GameManager.Instance.IncScore(1);
                    // Debug.Log("Inc Score!");
                }
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.name == "Hook")
        {
            // Debug.Log("hook collision");
            stage = 1;
        }
    }

}
