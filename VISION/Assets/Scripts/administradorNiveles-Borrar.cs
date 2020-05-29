using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(1);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
