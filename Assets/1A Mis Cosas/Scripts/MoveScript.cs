using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    //Variables
    public GameObject _ObjectoParaRotar;
    public int speedTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ObjectoParaRotar.transform.Rotate(0, Time.deltaTime * speedTime, 0, Space.Self);
    }
}
