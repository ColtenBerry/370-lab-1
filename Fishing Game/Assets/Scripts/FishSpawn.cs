using UnityEngine;

public class FishSpawn : MonoBehaviour
{

    public GameObject fish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateFish", 2.0f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFish() {
        Instantiate(fish);
    }
}
