using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastColorChange : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit myResult;
        bool wasHit = Physics.Raycast(transform.position, transform.forward, out myResult, Mathf.Infinity);
        //bool wasHit = Physics.SphereCast(transform.position, 5f, transform.forward, out myResult, Mathf.Infinity);



        if (wasHit)
        {
            Debug.DrawRay(transform.position, transform.forward * 1000f, Color.green, 0.05f);
            Debug.LogError("Boom!");
            Debug.LogError(myResult.rigidbody.gameObject);
            //Debug.LogError(myResult.point);
            myResult.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            //GameObject rayTargetObject = myResult
            myResult.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
        }
        else 
        {
            Debug.DrawRay(transform.position, transform.forward * 1000f, Color.red, 0.05f);
        }

    }
    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return color;
    }

}
