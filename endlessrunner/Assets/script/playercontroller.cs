using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{

    private Vector2 targetPosition;

    // private float incY = 3.5f;

    public float Maxheight;
    public float Minheight;
    public float speed;
    public float health = 3;
    public Text HealthText;
    public GameObject panel;




    void Update()
    {
        if (health <= 0)
        {
            panel.SetActive(true);
            Debug.Log("gameOver");
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < Maxheight)

        {
            //Debug.Log("UpArrow Passed");
            targetPosition = new Vector2(transform.position.x, transform.position.y + 3.5f);



        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > Minheight)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y - 3.5f);
        }

        HealthText.text = health.ToString();
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
    
    public void goUp()
    {
        if (transform.position.y < Maxheight)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y + 3.5f);

        }
    }
     public void goDown()
        {
            if (transform.position.y > Minheight)

            {
                targetPosition = new Vector2(transform.position.x, transform.position.y - 3.5f);
            }
        } 
}