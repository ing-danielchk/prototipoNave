using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviemiento : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocidad = 10.4f;

    public float movimientoHorizontal;
    public float movimientoVertical;

    public GameObject laser;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
        disparo();
    }

    void movimiento()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * velocidad * movimientoHorizontal * Time.deltaTime);

        movimientoVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * velocidad * movimientoVertical * Time.deltaTime);

        if (transform.position.x>= 2.739)
        {
            transform.position = new Vector3(2.739f, transform.position.y, -3.08f);
        }
        else if(transform.position.x <= 0.599)
        {
            transform.position = new Vector3(0.599f, transform.position.y, -3.08f);
        }
        else if(transform.position.y <= 1.094)
        {
            transform.position = new Vector3(transform.position.x, 1.094f, -3.08f);
        }
        else if (transform.position.y >= 4.241)
        {
            transform.position = new Vector3(transform.position.x, 4.250f, -3.08f);
        }
    }
    void disparo()
    {
        if(Input.GetKey(KeyCode.T))
        {
            Instantiate(laser, transform.position + new Vector3(0, 0.5f, -3.08f), Quaternion.identity);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(laser, transform.position + new Vector3(0, 0.5f, -3.08f), Quaternion.identity);
            Instantiate(laser, transform.position + new Vector3(0.2f,0, -3.08f), Quaternion.identity);
            Instantiate(laser, transform.position + new Vector3(-0.2f, 0, -3.08f), Quaternion.identity);
        }


    }

}
