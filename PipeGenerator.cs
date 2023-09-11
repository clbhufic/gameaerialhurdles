using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    public GameObject pipePrefabs;

    private float countdown;
    public float timeDuration;

    public bool enableGeneratePipes;

    private void Awake()
    {
        countdown = 0.5f;
        enableGeneratePipes = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableGeneratePipes == true)
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                Instantiate(pipePrefabs, new Vector3(10, Random.Range(-1.2f, 2.1f), 0), Quaternion.identity);
                countdown = timeDuration;
            }

        }
        
    }

    
}
