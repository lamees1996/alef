using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAdding : MonoBehaviour
{
    public GameObject dollar;

    // Start is called before the first frame update
    void Start()
    {
        for(float i=0;i<0.06f;i+=0.013f/4){
            GameObject refO = Instantiate(dollar, new Vector3(0,0, 0), Quaternion.identity);
            refO.transform.parent= gameObject.transform.parent;
            refO.transform.localEulerAngles =new Vector3(0,Random.Range(-10,10), 0)  ;
            refO.transform.position = new Vector3(0, i, 0);

        }
        
    }
}
