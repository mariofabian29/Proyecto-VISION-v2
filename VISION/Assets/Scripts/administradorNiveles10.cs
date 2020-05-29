using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles10 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(10);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
