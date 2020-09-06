using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
    
{
    public GameObject[] obstaclePatterns;
    private float timeBtwspawn;
    public float startTimeBtwspawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Start is called before the first frame update
    

    // Update is called once per frame
   private void Update()
    {
        if(timeBtwspawn<=0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwspawn = startTimeBtwspawn;
            if(startTimeBtwspawn>minTime)
            startTimeBtwspawn -= decreaseTime;
 
        }
        else
        {
            timeBtwspawn -= Time.deltaTime;
        }
    }
}
