using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComete : MonoBehaviour
{
    [SerializeField] float speed = 5;
    private Vector3 posDepart;
    private bool isPlaying = false;

    // Start is called before the first frame update
    void Awake()
    {
        posDepart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPlaying = !isPlaying;
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = posDepart;
        }

        if (isPlaying)
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
    }
}
