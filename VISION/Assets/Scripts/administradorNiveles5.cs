using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles5 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(5);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
