using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    InputManager inputManager;

    [SerializeField] float playerSpeed = 2f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector2 (inputManager.CurrentInput * Time.deltaTime * playerSpeed,0));
            
    }
}
