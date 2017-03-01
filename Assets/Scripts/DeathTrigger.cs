using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class DeathTrigger : MonoBehaviour {
	
	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("fuck you");
		if (other.gameObject.CompareTag("Player")) {
			EditorSceneManager.LoadScene (EditorSceneManager.GetActiveScene ().buildIndex);
		}
	}
}
