using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	float prevY = 0f;
	float prevDelta = 0f;

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
//        if (Input.GetButton("Fire1"));
//        {
//            this.gameObject.transform.Rotate(Vector3.down, Time.deltaTime * 10f);
//        }
		float yDelta = prevY - Camera.main.transform.localEulerAngles.y;
		// Debug.Log (yDelta);

		if (yDelta != 0f) {
			float yRot = Mathf.Lerp (prevDelta, yDelta, Time.deltaTime);
			// Debug.Log (yDelta + ", " + yRot);
			yRot *= 2f;
			transform.localEulerAngles = new Vector3 (0, 0, yDelta);
		}

		prevDelta = yDelta;
		prevY = Camera.main.transform.localEulerAngles.y;

    }
}
