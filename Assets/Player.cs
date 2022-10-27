using System.Collections;
using System.Collections.Generic;using DefaultNamespace;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] public PlayerProps playerProps;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"My health is {playerProps.maxHealth}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
