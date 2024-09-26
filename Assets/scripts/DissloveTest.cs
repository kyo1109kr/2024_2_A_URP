using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissloveTest : MonoBehaviour
{
    public Material material;         //���׸����� �޾ƿ´�
    public float amount = -1;         //������ ���� �޾ƿ´�
    public bool bDisslove;            //���� �÷���

    private void Start()
    {
        amount = -1;
        material.SetFloat("Amount", amount);
    }

    // Update is called once per frame
    void Update()
    {
        if(bDisslove)
        {
            amount = Time.deltaTime;
            material.SetFloat("_Amount", amount);

        }
    }
}
