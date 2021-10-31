using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public float speed = 0.35f;
        private float gravity = 10f;

        private CharacterController controller;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            // controller = GetComponent<CharacterController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            // float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // float v = CrossPlatformInputManager.GetAxis("Vertical");

            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            // Vector3 direction = new Vector3(horizontal,0,vertical);
            // Vector3 velocity = direction * speed;
            // velocity = Camera.main.transform.TransformDirection(velocity);
            // velocity.y -= gravity;
            // controller.Move(velocity * Time.deltaTime);
        }
    }
}
