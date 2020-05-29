using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles13 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(13);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
