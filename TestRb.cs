using UnityEngine;
using System.Collections;

public class TestRb : MonoBehaviour
{
	public Texture2D icon;

	public float speed;
	public float myMass;

	public GameObject mySphere;

	// Use this for initialization
	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.mass = myMass;
		rb.AddForce (Vector3.up * speed);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (10, 10, 100, 90), "Spawn Menu");

		if (Time.time % 2 < 1) {
			if (GUI.Button (new Rect (20, 40, 80, 20), "Balls")) {
				Instantiate (mySphere, new Vector3 (0, 0, 0), transform.rotation);
			}
		}

		GUI.Box (new Rect (10, 200, 300, 200), new GUIContent ("This is a Wolf!", icon));
	}
}