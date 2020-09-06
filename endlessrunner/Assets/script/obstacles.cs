
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<playercontroller>().health -= damage;
            Debug.Log(collision.GetComponent<playercontroller>().health);
            Destroy(gameObject);
        }    }
}
