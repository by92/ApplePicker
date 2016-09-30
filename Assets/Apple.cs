using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {
	public static float bottomy = -20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (transform.position.y < bottomy) {
		Destroy(this.gameobject);
		
	Applepicker apscript = camera.main.Getcomponent<ApplePicker> ();
	apScript.appledestroy
	}
}
