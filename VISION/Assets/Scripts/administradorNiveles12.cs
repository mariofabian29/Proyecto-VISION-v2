using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles12 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(12);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
