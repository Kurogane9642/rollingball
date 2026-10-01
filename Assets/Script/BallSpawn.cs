using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject SpawnObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(SpawnObject, new Vector3(0, 10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
