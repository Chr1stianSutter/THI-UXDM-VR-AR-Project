using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    public float m_Sensitivity;
    public float m_MaxSpeed;

    public SteamVR_Action_Boolean m_MovePress = null;
    public SteamVR_Action_Vector2 m_MoveValue = null;

    private float m_Speed = 0.0f;

    private CharacterController m_CharacterController = null;
    public Transform m_CameraRig;
    public Transform m_Head;

    public SteamVR_Input_Sources source = SteamVR_Input_Sources.RightHand;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        //m_CameraRig = SteamVR_Render.Top().origin;
        //m_Head = SteamVR_Render.Top().head;

    }

    private void Update()
    {
        HandleHead();
        HandleHeight();
        CalculateMovement();

    }

    private void HandleHead()
    {
        //Store current
        Vector3 oldPosition = m_CameraRig.position;
        Quaternion oldRotation = m_CameraRig.rotation;

        //Rotation
        transform.eulerAngles = new Vector3(0.0f, m_Head.rotation.eulerAngles.y, 0.0f);

        //Restore
        m_CameraRig.position = oldPosition;
        m_CameraRig.rotation = oldRotation;
    }

    private void CalculateMovement()
    {
        // Figure out movement orientation
        Vector3 orientationEuler = new Vector3(0, transform.eulerAngles.y, 0);
        Quaternion orientation = Quaternion.Euler(orientationEuler);
       
        Vector3 movement = Vector3.zero;
        Vector3 movementX = Vector3.zero;


        // If not moving
        if (m_MovePress.GetStateUp(source))
        {
            m_Speed = 0;
        }

        // If button pressed
        if (true)
        {
            // Add, clamp
            m_Speed += m_MoveValue.axis.y * m_Sensitivity;
            m_Speed = Mathf.Clamp(m_Speed, -m_MaxSpeed, m_MaxSpeed);
            Debug.Log(m_MoveValue.axis.y);

            // Orientation
            //movement += orientation * (m_Speed * Vector3.forward) * Time.deltaTime;
            //Debug.Log(movement);

            if (m_MoveValue[source].axis.y > -1 && m_MoveValue[source].axis.y < 0)
            {
                //is Walking backwards
                movement += orientation * (m_MoveValue[source].axis.y * Vector3.forward * m_Sensitivity / 2 + m_MoveValue[source].axis.x * Vector3.right * m_Sensitivity / 2) * Time.deltaTime;
            }
            else
            {
                //is walikg forward or left or right
                movement += orientation * (m_MoveValue[source].axis.y * Vector3.forward * m_Sensitivity + m_MoveValue[source].axis.x * Vector3.right * m_Sensitivity / 2) * Time.deltaTime;
            }

            movementX = new Vector3(m_MoveValue[source].axis.x * m_Sensitivity, 0, 0);

        }


        //Apply
        //characterController.Move(movement);

    

        // Apply
       m_CharacterController.Move(movement);
    }

    private void HandleHeight()
    {
        // Get the head in local space
        float headHeight = Mathf.Clamp(m_Head.localPosition.y, 1, 2);
        m_CharacterController.height = headHeight;

        // Cut in half
        Vector3 newCenter = Vector3.zero;
        newCenter.y = m_CharacterController.height / 2;
        newCenter.y += m_CharacterController.skinWidth;

        // Move capsule in local space
        newCenter.x = m_Head.localPosition.x;
        newCenter.z = m_Head.localPosition.z;

        // Rotate
        newCenter = Quaternion.Euler(0, -transform.eulerAngles.y, 0) * newCenter;

        // Apply
        m_CharacterController.center = newCenter;
    }
}