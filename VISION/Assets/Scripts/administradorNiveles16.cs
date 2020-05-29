using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles16 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(16);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
