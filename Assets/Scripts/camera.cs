using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject maincamera;
    GameObject parameters; //parametersのオブジェクトを取得
    parameters script; //parametersのスクリプトが入る変数

    // Start is called before the first frame update
    void Start()
    {
        parameters = GameObject.Find("Parameters");
        maincamera = GameObject.Find("Main Camera");
        script = parameters.GetComponent<parameters>();
    }

    // Update is called once per frame
    void Update()
    {
        float length1 = script.length; //振り子の長さ
        Transform cameratrans = maincamera.transform;
        Vector3 pos = cameratrans.position;
        pos.z = -length1 *1.7f - 2;
        cameratrans.position = pos;
    }
}
