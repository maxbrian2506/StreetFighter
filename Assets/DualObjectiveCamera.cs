using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualObjectiveCamera : MonoBehaviour {
    [SerializeField] Transform LeftTarget ;
    [SerializeField] Transform rightTarget;

    [SerializeField] float minDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float Distance = Mathf.Abs(LeftTarget.position.x - rightTarget.position.x) * 2;
        float centerposition = (LeftTarget.position.x + rightTarget.position.x) / 2;
        transform.position = new Vector3(centerposition, transform.position.y, Distance > minDistance ? -Distance : -minDistance);
	}
}
