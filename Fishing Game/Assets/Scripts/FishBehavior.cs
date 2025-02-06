using UnityEngine;

public class FishBehavior : MonoBehaviour
{
    public GameObject hook;

    public int stage = 0;

    public float swimSpeedMedium = 3.0f;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (stage)
        {
            case 0:
                transform.Translate(Vector3.right * swimSpeedMedium * Time.deltaTime);
                break;
            case 1:
                transform.Translate(Vector3.up * speed * Time.deltaTime * 2);
                if (transform.position.y > 3.1)
                {
                    Destroy(gameObject);
                }
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.name == "Hook")
        {
            Debug.Log("hook collision");
            stage = 1;
        }
    }

}
