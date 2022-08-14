using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    GameObject parameters; //parametersのオブジェクトを取得
    parameters script; //parametersのスクリプトが入る変数

    float g; //重力加速度
    float angularacceleration; //角加速度
    float angularvelocity; //角速度
 

    // Start is called before the first frame update
    public void Start()
    {
       
        parameters = GameObject.Find("Parameters");
        script = parameters.GetComponent<parameters>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float length = script.length; //振り子の長さ
        float angle = script.angle; //振り子の角度

        angularacceleration = - g / length * Mathf.Sin(angle * Mathf.Deg2Rad);

    }

    
}
