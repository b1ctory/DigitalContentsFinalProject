using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCameraMoving : MonoBehaviour
{
   public GameObject ch; // 인스펙터 창에서 캐릭터를 여기에 조인한다.
	void Start () {

		transform.position = ch.transform.position;  // 캐릭터 좌표를 카메라 좌표로 ..

	}

	

	// Update is called once per frame

	void Update () {

		transform.position = ch.transform.position;

	}

}
