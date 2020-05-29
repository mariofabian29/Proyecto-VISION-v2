using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles9 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(9);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
