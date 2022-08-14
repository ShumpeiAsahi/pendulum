using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parameters : MonoBehaviour
{
    GameObject pivot;
    GameObject ball;
    Rigidbody rb;
    GameObject start;
    public float length = 1;
    public float angle = 90;
    public float mass = 1;
    public float scale = 1;
    Transform balltrans;
    HingeJoint joint;
    Vector3 jointca;
    GameObject lengthtext;
    GameObject angletext;
    GameObject masstext;
    GameObject scaletext;
    GameObject timetext;
    float time;



    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("Start");
        pivot = GameObject.Find("Pivot");
        ball = GameObject.Find("Ball");
        timetext = GameObject.Find("TimeText");

        //mass = 1;
        //Rigidbodyを取得
        rb = ball.GetComponent<Rigidbody>();
        joint = pivot.GetComponent<HingeJoint>();
        jointca = joint.connectedAnchor;

        lengthtext = GameObject.Find("Length");
        angletext = GameObject.Find("Angle");
        masstext = GameObject.Find("Mass");
        scaletext = GameObject.Find("Scale");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(start.activeSelf == true)
        {

            Transform balltrans = ball.transform;
            Vector3 pos = balltrans.position;
            pos.x = length * Mathf.Sin(angle * Mathf.Deg2Rad);
            pos.y = -length * Mathf.Cos(angle * Mathf.Deg2Rad);
            balltrans.position = pos;
            jointca.x = -5 * length;
            joint.connectedAnchor = jointca;

            rb.mass = mass;
            //ball.transform.localScale = new Vector3(0.2f * scale, 0.2f * scale, 0.2f * scale);
        }

        lengthtext.GetComponent<Text>().text = length + " m";
        angletext.GetComponent<Text>().text = angle + " °";
        masstext.GetComponent<Text>().text = mass + " kg";
        scaletext.GetComponent<Text>().text = "x " + scale;

        if (start.activeSelf == false)
        {
            time += Time.deltaTime;
            timetext.GetComponent<Text>().text = time + "'";
        }
    }

    public void PluslengthDown()
    {
        length += 1;
    }
    public void MinuslengthDown()
    {
        length -= 1;
    }
    public void PlusangleDown()
    {
        angle += 10;
    }
    public void MinusangleDown()
    {
        angle -= 10;
    }
    public void PlusmassDown()
    {
        mass += 1;
    }
    public void MinusmassDown()
    {
        mass -= 1;
    }
    public void PlusscaleDown()
    {
        scale += 1;
    }
    public void MinusscaleDown()
    {
        scale -= 1;
    }


    public void StartDown()
    {
        rb.isKinematic = false;
        start.gameObject.SetActive(false);

    }

}
