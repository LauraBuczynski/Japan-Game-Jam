using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeController : MonoBehaviour {

	[SerializeField]
	float canSeeDis = 10f;

	[SerializeField]
    float canSeeDir = 30f;

	private float lookTime;

	private bool m_isLooked = false;

	GameObject player;

	void Start()
    {
        lookTime = 0.0f;
		player = GameObject.FindWithTag("Player");
	}

    void Update()
    {
        lookTime += Time.deltaTime;

		DebugDraw();

		if (lookTime > 0.5f)
		{
			lookTime = 0.0f;

			float angleDir = this.transform.eulerAngles.y * (Mathf.PI / 180.0f);
			Vector3 dir = transform.forward;

			Vector3 birdV3 = player.transform.position;

			float tmpDis = Vector3.Distance(player.transform.position, this.transform.position);

			Vector3 tmpV3 = (player.transform.position - this.transform.position).normalized;
			Vector3 tmpV2 = new Vector3(tmpV3.x, 0f, tmpV3.z);

			float angle = Vector3.Angle(dir, tmpV2);

			if (angle < canSeeDir && tmpDis < canSeeDis){
				m_isLooked = true;
			}
			else{
				m_isLooked = false;
			}
		}

	}

	public bool IsLook()
    {
        return m_isLooked;
    }

	public GameObject GetPlayer(){
		return player;
	}

	void DebugDraw()
	{
		Vector3 dir = transform.forward * canSeeDis;

		Debug.DrawRay(transform.position, dir, Color.red, 0.01f, false);
		Debug.DrawRay(transform.position, Quaternion.Euler(0.0f, canSeeDir, 0.0f) * dir, Color.red, 0.01f, false);
		Debug.DrawRay(transform.position, Quaternion.Euler(0.0f, -canSeeDir, 0.0f) * dir, Color.red, 0.01f, false);

		if (IsLook()){
			Debug.Log("Look Player");
		}
	}
}
