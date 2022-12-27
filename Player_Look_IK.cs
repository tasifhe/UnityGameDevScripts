using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Look_IK : MonoBehaviour
{

    private Animator _animator;
    private Camera _mainCamera;
    //Variables
    [SerializeField,Range(0,1)]
    private float weight;
    [SerializeField,Range(0,1)]
    private float bodyWeight;
    [SerializeField,Range(0,1)]
    private float headWeight;
    [SerializeField,Range(0,1)]
    private float eyeWeight;
    [SerializeField,Range(0,1)]
    private float clampWeight;
    [SerializeField,Range(10,50)]
    private float Distance;



    void Start()
    {
        _animator = GetComponent<Animator>();
        _mainCamera = Camera.main;
        
    }

    private void OnAnimatorIK(int layerIndex) 
    {
        _animator.SetLookAtWeight(weight,bodyWeight,headWeight,eyeWeight,clampWeight);
        Ray lookAtRay = new Ray(transform.position,_mainCamera.transform.forward);
        _animator.SetLookAtPosition(lookAtRay.GetPoint(Distance));
        
    }
}
