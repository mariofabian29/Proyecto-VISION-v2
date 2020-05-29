using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class TutScript : MonoBehaviour
{

    public float speed;
    private float amoutToMove;

    public float vel;
    private int dir;

    SerialPort sp = new SerialPort("COM5", 9600); 

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        amoutToMove = speed * Time.deltaTime;

        if (sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                mover(sp.ReadLine());
                print(sp.ReadByte());
            }
            catch (System.Exception)
            {

            }
        }
    }

    void MoveObject(int Direction)
    {

        if (Direction == 1)
        {
            transform.Translate(Vector3.left * amoutToMove, Space.World);
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * amoutToMove, Space.World);
        }
    }

    void mover(string datoArduino)
    {
        string[] datosArray = datoArduino.Split(char.Parse(","));

        if (datosArray.Length == 1)
        {
            dir = int.Parse(datosArray[0]);
            print(dir);
        }

        if (dir >= 10)
        {
            //Space.Self Space.World
            transform.Rotate(Vector3.up * vel, Space.Self);
        }

        if (dir < 20)
        {
            //Space.Self Space.World
            transform.Rotate(Vector3.down * vel, Space.Self);
        }
    }
}
