using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaMovement = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            deltaMovement += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            deltaMovement += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            deltaMovement += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            deltaMovement += new Vector3(0, 1, 0);
        }

        transform.position += deltaMovement * moveSpeed * Time.deltaTime;
    }
}
