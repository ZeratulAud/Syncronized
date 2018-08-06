using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrateTrigger : MonoBehaviour {

    [SerializeField] private string NextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Key")
        {
            SceneManager.LoadScene(NextLevel);
        }
    }
}
