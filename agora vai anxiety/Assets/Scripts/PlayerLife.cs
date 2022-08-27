﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
            transform.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(TimeDelay());
            
        }
    }

    IEnumerator TimeDelay()
            {
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
