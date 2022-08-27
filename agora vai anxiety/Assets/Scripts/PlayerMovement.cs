using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour

{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    private bool is_paused;
    public GameObject pause_painel;
    public string cena;

// Update is called once per frame
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_paused)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }

            
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseScreen();
            }
    }

    void PauseScreen()
    {
        if (is_paused)
        {
            is_paused = false;
            Time.timeScale = 1f;
            pause_painel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        else
        {
            is_paused = true;
            Time.timeScale = 0f;
            pause_painel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void BacktToMenu()
    {

        SceneManager.LoadScene(cena);
    }

    void FixedUpdate ()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
