using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalScript : MonoBehaviour
{
    private int currentIndex;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
            {
                SceneManager.LoadScene(currentIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
            //Debug.Log("Goal");
            //Time.timeScale = 0;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
