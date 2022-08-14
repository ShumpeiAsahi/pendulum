using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class measurement : MonoBehaviour
{
    MeshRenderer mr;
    float count;  //通り過ぎた回数
    float time;  //通り過ぎた時の経過時間
    GameObject ball;
    Rigidbody rb;

    float velocityxbefore;
    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトを非表示
        mr = GetComponent<MeshRenderer>();
        mr.material.color = mr.material.color - new Color32(0, 0, 0, 255);
        ball = GameObject.Find("Ball");
        rb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)　//周期の計測
    {
        //if (other.gameObject.tag == "ball")
        {
            //count += 1;
            //if (count % 2 == 1)
            {
                //Debug.Log((count - 1) / 2 + "周期目の周期" + Time.time);
                //float angularvelo = Mathf.Sqrt(Mathf.Pow(rb.velocity.x, 2) + Mathf.Pow(rb.velocity.y, 2)) * 1;
                //Debug.Log((count - 1) / 2 + "周期目の角速度" + angularvelo);

                //string txt = (count - 1) / 2 + "," + Time.time + "," + angularvelo * angularvelo * 0.5 + ","　+ angularvelo;
                //StreamWriter sw = new StreamWriter("../HingeEnergy30.txt", true);// TextData.txtというファイルを新規で用意
                //sw.WriteLine(txt);// ファイルに書き出したあと改行
                //sw.Flush();// StreamWriterのバッファに書き出し残しがないか確認
                //sw.Close();// ファイルを閉じる

                
            }
        }
    }
    private void FixedUpdate()
    {
        Mathf.Pow(rb.velocity.x, 2);
        float time = Time.time;

        if (rb.velocity.x >= 0 && velocityxbefore < 0)
        {
            count += 1;

            Debug.Log(count + "周期目" + "経過時間" + time );

            string txt = count + "," + time;
            StreamWriter sw = new StreamWriter("../PendulumExperiment_HingeJoint.txt", true);// TextData.txtというファイルを新規で用意
            sw.WriteLine(txt);// ファイルに書き出したあと改行
            sw.Flush();// StreamWriterのバッファに書き出し残しがないか確認
            sw.Close();// ファイルを閉じる

        }
        velocityxbefore = rb.velocity.x;
    }
}
