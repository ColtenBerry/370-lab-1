using UnityEngine;

public class FishSpawn : MonoBehaviour
{

    public GameObject bigfish;
    public GameObject mediumfish;
    public GameObject smallfish;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("CreateBigFish", 4.0f, 6.0f);
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
        Instantiate(smallfish);
    }
    void CreateMediumFish() {
        Instantiate(mediumfish);
    }
}
