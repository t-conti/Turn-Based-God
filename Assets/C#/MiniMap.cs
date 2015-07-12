using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour {

	public Camera mapCam;
	public RawImage image;


	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<RawImage>();
	}
	
	// Update is called once per frame
	void Update () {
		image.texture = (Texture)mapCam.targetTexture;
	}
}
