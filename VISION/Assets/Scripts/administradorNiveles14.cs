using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles14 : MonoBehaviour {

	public void irAjuego()
	{
		
		SceneManager.LoadScene(14);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
