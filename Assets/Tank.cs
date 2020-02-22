using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [Range(0f,5f)]
    [SerializeField] float movementSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y); 
    }
}
