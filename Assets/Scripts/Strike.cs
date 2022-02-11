using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strike : MonoBehaviour
{
    Vector3 hammerPosition;
    Vector3 temp;

    private Rigidbody rb;
    private float forceToApply = 0;
    private float time;

    public Text forceTextBox;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hammerPosition = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * 0);
        transform.Rotate(Vector3.right * 0);

        if (Input.GetKey("c"))
        {
            forceToApply += 1f;
            forceTextBox.text = forceToApply.ToString();

            if (forceToApply > 3000f)
            {
                forceTextBox.color = Color.red;
            }
            else
                forceTextBox.color = Color.black;
        }

        if (Input.GetKey("v"))
        {
            temp = hammerPosition;
            rb.AddForce(-forceToApply * 300 * Time.deltaTime, 0, 0);
            forceToApply = 0;
            forceTextBox.text = (forceToApply).ToString();
            time = 2f;
        }

        if (time < 0)
            hammerPosition = temp;
        else
            time -= Time.deltaTime;
    }
}
