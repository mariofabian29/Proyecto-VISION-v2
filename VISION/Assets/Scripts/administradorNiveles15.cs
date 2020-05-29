using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles15 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(15);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
