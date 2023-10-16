using UnityEngine;
using System.Collections;

public class HitBox : MonoBehaviour
{
    public string messageOnPrint;

    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.Log(messageOnPrint);
        }
    }
}
