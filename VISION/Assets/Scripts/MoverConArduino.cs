using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;



public class MoverConArduino : MonoBehaviour
{

    private int dir1;
    private int btn1;
    private int btn2;
    public float vel;


    public GameObject objeto;

    public float distanciaMov = 50;


    SerialPort PuertoSerial = new SerialPort("COM5", 9600);

    void Start()
    {
        PuertoSerial.Open();
        PuertoSerial.ReadTimeout = 1;
    }

    void Update()
    {
        if (PuertoSerial.IsOpen)
        {
            try
            {
                mover(PuertoSerial.ReadLine());

            }
            catch (System.Exception)
            {

            }

        }

    }

    void mover(string datoArduino)
    {
        string[] datosArray = datoArduino.Split(char.Parse(","));

        if (datosArray.Length == 3)
        {
            dir1 = int.Parse(datosArray[0]);
            btn1 = int.Parse(datosArray[1]);
            btn2 = int.Parse(datosArray[2]);
            print(dir1 + " " + btn1 + " " + btn2);
        }
        /*
        if (dir1 >= 500)
        {
            //Space.Self Space.World
            transform.Rotate(Vector3.up * vel, Space.Self);
        }

        if (dir1 < 500)
        {
            //Space.Self Space.World
            transform.Rotate(Vector3.down * vel, Space.Self);
        }

        if (btn1 == 1)
        {
            //Space.Self Space.World
            transform.Translate(0, 0, -0.6f);
        }

        if (btn2 == 1)
        {
            //Space.Self Space.World
            transform.Translate(0, 0, 0.6f);
        }
        */

    }
}












