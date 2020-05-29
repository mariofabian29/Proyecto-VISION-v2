using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles11 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(11);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
