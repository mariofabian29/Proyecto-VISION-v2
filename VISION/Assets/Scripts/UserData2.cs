using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData2 : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/phpVISION/escribir2.php";

    private string nombre = "";
    private string licencia = "";

    public InputField campoNombre;
    public InputField campoLicencia;


    public void SenData()
    {
        //es llamar a un metodo generando una pausa en la ejecución del programa hasta que se realiza lo que esta dentro del metodo
        StartCoroutine(enviarDatosUsuario());
    }

    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        licencia = campoLicencia.text;

        print(nombre + "  " + licencia);


        if (nombre == "" || licencia == "")
        {
            print("los campos de nombre, apellido y edad deben tener información");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("nombre", nombre);
            form.AddField("licencia", licencia);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);

        }



    }
}