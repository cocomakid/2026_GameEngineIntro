using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector2 moveInput;
    private float speed = 5.0f;
    
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (moveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
           
        }
        else if (moveInput.x < 0 || moveInput.y < 0 && moveInput.y > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);
        transform.Translate(Vector3.up * moveInput.y * Time.deltaTime * speed);
    }
}
