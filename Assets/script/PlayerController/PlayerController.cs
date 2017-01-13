using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public Text countText;
    public Text WinText;

    private int count;
    private Rigidbody rb;

    void Start()
    {
        rb              = GetComponent<Rigidbody>();
        count           = 0;
        WinText.text    = " ";
        
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 17)
        {
            WinText.text = "You Win ! ";
        }
    }
}