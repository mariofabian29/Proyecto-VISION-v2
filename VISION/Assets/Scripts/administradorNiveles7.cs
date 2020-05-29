using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles7 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(7);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
