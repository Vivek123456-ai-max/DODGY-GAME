using UnityEngine;

public class PlayerHit : MonoBehaviour
{

    private int hitCount = 0;
    private Rigidbody rb;
    private Move moveScript;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveScript = GetComponent<Move>();  
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Player Collided");
        //Debug.Log(collision.gameObject.name);
        hitCount += 1;
        Debug.Log("Player has cillided " + hitCount + " times " );

        if(collision.gameObject.CompareTag("Obstacles"))
        {
           ChangeColor(collision.gameObject, Color.black);
           GameOver();
        }
        /*
        Transform transform = collision.gameObject.GetComponent<Transform>();
        transform.localScale = new Vector3(1, 1, 1);
        */
    }

    private void ChangeColor(GameObject gameObject, Color color)
    {
         MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        Material material = meshRenderer.material;
        material.color = color;
    }

    private bool GameOver()
    {
        rb.constraints = RigidbodyConstraints.None;
           rb.useGravity = true;
           moveScript.enabled = false;
           return true;
    }
}
