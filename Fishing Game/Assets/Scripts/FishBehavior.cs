using UnityEngine;

public class FishBehavior : MonoBehaviour
{
    GameObject hook;
    public int stage = 0;
    public float speed = 2.0f;
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
                break;
            case 1:
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.name == "Circle")
        {
            Debug.Log("hook collision");
            stage = 1;

        }
    }

}
