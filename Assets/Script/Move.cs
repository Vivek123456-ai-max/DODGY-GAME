using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Welcome();
    }

    // Update is called once per frame
    void Update()
    {
         MovePlayer();
    }

    void Welcome() 
    {
        Debug.Log("Welcome To Dodgy Game");
        Debug.Log("Move The Player With WASD");
    }

    void MovePlayer()
    {
        float valueX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float valueY = 0;
        float valueZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(valueX, valueY, valueZ);
    }
}
