using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    private bool isGameOver = false;
    // Start is called before the first frame update
    public Rotator rotator;
    public Spawner spawner;

    void Start()
    {
        
    }
    public void GameOver()
    {
        if (isGameOver == false)
        {
            isGameOver = true;
            rotator.enabled = false;
            spawner.enabled = false;
            GetComponent<Animator>().SetTrigger("Gameover");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
