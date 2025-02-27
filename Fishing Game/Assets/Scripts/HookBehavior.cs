using UnityEngine;

public class HookBehavior : MonoBehaviour
{
    public float speed = 1.0f;
    public int stage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("collision!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("trigger");
        stage = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("mouse 0"))
        {
            stage = 1;
            // Debug.Log("click!");
        }

        switch (stage)
        {
            case 0: //hook follows mouse
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(pos.x, transform.position.y);
                break;
            case 1: //hook goes down
                transform.Translate(0, -(speed * Time.deltaTime), 0);
                if (transform.position.y < 1.0)
                {
                    stage = 2;
                }
                break;
            case 2: //hook goes up
                transform.Translate(0, speed * Time.deltaTime * 2, 0);
                if (transform.position.y > 10.785)
                {
                    stage = 0;
                }
                break;

        }
    }
}
