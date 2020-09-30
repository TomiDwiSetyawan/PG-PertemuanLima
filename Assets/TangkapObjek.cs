using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapObjek : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bola;
    public GameObject tangan;
    public GameObject cube;

    bool tertangkap = false;
    Vector3 posisiBola;
    void Start()
    {
        posisiBola = bola.transform.position;
        cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(5.88f, 2.95f, 0f);
                cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
                bola.GetComponent<Renderer>().material.color = Color.blue;
                tertangkap = true;
            } else if (tertangkap)
            {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                cube.transform.localPosition = new Vector3(5.88f, 2.22f, -0.97f);
                bola.GetComponent<Renderer>().material.color = Color.red;
                tertangkap = false;
            }
            
        }
    }
}
