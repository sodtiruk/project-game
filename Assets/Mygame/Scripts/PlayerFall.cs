using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    // Start is called before the first frame update
    public float deathHeight = -10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathHeight)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("player has fallen to their death");
    }
}
