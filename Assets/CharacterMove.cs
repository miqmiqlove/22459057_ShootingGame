using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CharacterMove: MonoBehaviour
{
    public float spd = 5;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        //Vector3 direct = Vector3.right * h + Vector3.up * v;
        Vector3 direct = new Vector3(h, v, 0);

        //trasform.Translate(direct * spd * Time.deltaTime);
        transform.position = transform.position + direct * spd * Time.deltaTime;
    }
}
