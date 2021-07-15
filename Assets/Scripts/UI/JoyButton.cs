using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyButton : MonoBehaviour
{
    protected Joystick joystick;
    protected JoyButton joyButton;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>();

        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 30f, rigidbody.velocity.y, joystick.Vertical * 30f);


    }
}
