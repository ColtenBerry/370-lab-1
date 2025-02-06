using UnityEngine;

public class FishSpawn : MonoBehaviour
{

    public GameObject bigfish;
    public GameObject mediumfish;
    public GameObject smallfish;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateBigFish", 4.0f, Random.Range(6.0f, 8.0f));
        InvokeRepeating("CreateSmallFish", 1.0f, Random.Range(2.0f, 3.5f));
        InvokeRepeating("CreateMediumFish", 3.0f, Random.Range(3.5f, 5.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBigFish() {
        var position = new Vector3(-11.0f, Random.Range(-4.5f, -2.5f), 0.0f);
        Instantiate(bigfish, position, Quaternion.identity);
    }
    void CreateSmallFish() {
        var position = new Vector3(-11.0f, Random.Range(-1.5f, 2.0f), 0.0f);
        Instantiate(smallfish, position, Quaternion.identity);
    }
    void CreateMediumFish() {
        var position = new Vector3(-11.0f, Random.Range(-2.0f, 1.0f), 0.0f);
        Instantiate(mediumfish, position, Quaternion.identity);
    }
}
