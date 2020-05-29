using UnityEngine;
using System.Collections;

public class Puntaje : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/phpVISION/escribir2.php";
    private int idVISION = 0;
    private int Nivel = 0;
    private int Errores = 0;

    public int value = 33;
	public GameObject explosionPrefab;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (GameManager.gm != null)
			{
				// tell the game manager to Collect
				GameManager.gm.Collect(value);
                StartCoroutine(sendItem());
            }




			// explode if specified
			if (explosionPrefab != null)
			{
				Instantiate(explosionPrefab, transform.position, Quaternion.identity);
			}

			// destroy after collection
			Destroy(gameObject);
		}

		if (other.gameObject.tag == "Finish")
		{

			// destroy after collection
			Destroy(gameObject);
		}
	}



    public IEnumerator sendItem()
    {

        print(idVISION + " " + Nivel + " " + value);

        WWWForm form = new WWWForm();

        form.AddField("id", idVISION);
        form.AddField("niv", Nivel);
        form.AddField("err", value);

        WWW retroalimentacion = new WWW(UrlPosition, form);

        yield return retroalimentacion;

        print(retroalimentacion.text);

    }
}