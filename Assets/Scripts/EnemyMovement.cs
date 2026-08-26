using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(moveSpeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moveSpeed = -moveSpeed;

        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.linearVelocity.x)), 1f);
    }
}
