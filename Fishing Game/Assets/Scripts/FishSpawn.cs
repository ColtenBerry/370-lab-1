using UnityEngine;

public class FishSpawn : MonoBehaviour
{

    public GameObject bigfish;
    public GameObject mediumfish;
    public GameObject smallfish;
    private Vector3 bigcoord = new Vector3(-11.0f,-4.0f,0.0f);

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
        Instantiate(bigfish, bigcoord, Quaternion.identity);
    }
    void CreateSmallFish() {
        Instantiate(smallfish);
    }
    void CreateMediumFish() {
        Instantiate(mediumfish);
    }
}
