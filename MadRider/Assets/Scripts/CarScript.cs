using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{

    WheelJoint2D[] wheelJoints;
    JointMotor2D frontWheel;
    JointMotor2D backWheel;

    public float maxSpeed = -1000f;
    private float maxBackSpeed = 1500f;
    private float acceleration = 400f;
    private float deacceleration = -200f;
    public float brakeForce = 3000f;
    private float gravity = 9.8f;
    private float angleCar = 0;
    public bool grounded = false;
    public LayerMask map;
    public Transform Bwheel;
    private int coinsInt = 0;
    public Text coinsText;

    public ClickScript[] ControlCar;

    // Use this for initialization
    void Start()
    {

        wheelJoints = gameObject.GetComponents<WheelJoint2D>();
        backWheel = wheelJoints[1].motor;
        frontWheel = wheelJoints[0].motor;
    }

    void Update()
    {
        grounded = Physics2D.OverlapCircle(Bwheel.transform.position, 0.505f, map);
    }

    void FixedUpdate()
    {

        frontWheel.motorSpeed = backWheel.motorSpeed;

        angleCar = transform.localEulerAngles.z;

        if (angleCar >= 180)
        {
            angleCar = angleCar - 360;
        }

        if (grounded == true)
        {
            if (ControlCar[0].clickedIs == true)
            {
                backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (acceleration - gravity * Mathf.PI * (angleCar / 180) * 100) * Time.deltaTime, maxSpeed, maxBackSpeed);
            }
            else if ((backWheel.motorSpeed < 0) || (ControlCar[0].clickedIs == false && backWheel.motorSpeed == 0 && angleCar < 0))
            {
                backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - gravity * Mathf.PI * (angleCar / 180) * 100) * Time.deltaTime, maxSpeed, 0);
            }
            if ((ControlCar[0].clickedIs == false && backWheel.motorSpeed > 0) || (ControlCar[0].clickedIs == false && backWheel.motorSpeed == 0 && angleCar > 0))
            {
                backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - gravity * Mathf.PI * (angleCar / 180) * 100) * Time.deltaTime, 0, maxBackSpeed);
            }
        }
        else if (ControlCar[0].clickedIs == false && backWheel.motorSpeed < 0)
        {
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - deacceleration * Time.deltaTime, maxSpeed, 0);
        }
        else if (ControlCar[0].clickedIs == false && backWheel.motorSpeed > 0)
        {
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + deacceleration * Time.deltaTime, 0, maxBackSpeed);
        }
        if (ControlCar[0].clickedIs == true && grounded == false)
        {
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (acceleration - gravity * Mathf.PI * (angleCar / 180) * 100) * Time.deltaTime, maxSpeed, maxBackSpeed);
        }

        if (ControlCar[1].clickedIs == true && backWheel.motorSpeed > 0)
        {
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, maxBackSpeed);
        }
        else if (ControlCar[1].clickedIs == true && backWheel.motorSpeed < 0)
        {
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, maxSpeed, 0);
        }

        wheelJoints[1].motor = backWheel;
        wheelJoints[0].motor = frontWheel;
    }
    /*void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Bwheel.transform.position, 0.505f);
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "coins")
        {
            coinsInt++;
            Destroy(trigger.gameObject);
        }
        else if (trigger.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(0);
        }
    }*/
}