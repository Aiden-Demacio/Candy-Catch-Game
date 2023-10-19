using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;


    public float speed;
    public float horizontalInput;
    float score = 0;
        

    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput != 0)
        {
            rb.AddForce(new Vector3(horizontalInput * speed, 0f, 0f));
        }
        
    }



    public void scoreCount(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

}
