/*using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Moved(h, v, v, 0f);
#endif
        }
        //ENVAR UN VALOR A H Y OTRO A V, 0 a 450 -1 ... de 450 a 550 0 ... y de 550 a 1000 un 1.. editar linea 23 24
    }
}*/






using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.IO.Ports;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {

        private int dir1;
        private int btn1;
        private int btn2;

        SerialPort PuertoSerial = new SerialPort("COM3", 9600);


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
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        void mover(string datoArduino)
        {
            string[] datosArray = datoArduino.Split(char.Parse(","));

            if (datosArray.Length == 3)
            {
                dir1 = int.Parse(datosArray[0]);
                btn1 = int.Parse(datosArray[1]);
                btn2 = int.Parse(datosArray[2]);


                print(dir1 + " " + btn1+ " " + btn2);
            }
        }


        private CarController m_Car; // the car controller we want to use


      /*  private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Moved(h, v, v, 0f);
#endif
        }*/


        private void FixedUpdate()
        {
            int v = 0;

            if (btn1 == 1)
            {
                //Debug.Log("Presionado - 1");
                v= 1;


            }
            /*else if (btn1 == 0) 
            {
                v= 0;
            }
            */
            if (btn2 == 1)
            {
                //Debug.Log("Presionado - 1");
                v = -1;


            }/*
            else if (btn2 == 0)
            {
                v = 0;
            }*/



            int h = 0;

            if (dir1 <= 499)
            {
                //Debug.Log("Menor");
                h = -1;
            }

            if (dir1 >= 500)
            {
                //Debug.Log("Punto Medio");
                h = 0;
            }



            if (dir1 >= 601)
            {
               // Debug.Log("Mayor");
                h = 1;
            }

            // pass the input to the car!


#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Moved(h, v, v, 0f);
#endif
        }
    }
}

