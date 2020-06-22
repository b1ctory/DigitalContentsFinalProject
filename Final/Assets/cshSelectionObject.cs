using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSelectionObject : MonoBehaviour
{
public Camera cam;
void Update()
{
if (Input.GetMouseButtonDown(0))
{
RaycastHit hit;
Ray ray = cam.ScreenPointToRay(Input.mousePosition); if (Physics.Raycast(ray, out hit, Mathf.Infinity))
{
Debug.Log(hit.transform.gameObject); }
}
} }