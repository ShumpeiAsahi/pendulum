using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atplaneobject : MonoBehaviour
{
    GameObject parameters; //parametersのオブジェクトを取得
    parameters script; //parametersのスクリプトが入る変数

    // Start is called before the first frame update
    void Start()
    {
        parameters = GameObject.Find("Parameters");
        script = parameters.GetComponent<parameters>();
    }

    // Update is called once per frame
    void Update()
    {
        float length1 = script.length; //振り子の長さ
        Transform trans = this.transform;
        Vector3 pos = trans.position;
        pos.y = -length1 * 1.2f ;
        trans.position = pos;
    }
}
