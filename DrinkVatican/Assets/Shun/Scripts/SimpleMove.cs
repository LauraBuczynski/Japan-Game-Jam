using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
	[SerializeField]
	private float m_maxSpd = 2.0f;

	Rigidbody m_rb;

	private float m_timer = 3.0f;

	void Start()
	{
		m_rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		m_timer += Time.deltaTime;
		if (m_timer > 3.0f)
		{
			m_timer = 0.0f;
			RoamMoving(gameObject, m_rb,m_maxSpd);
		}
	}

	static public void RoamMoving(GameObject obj, Rigidbody rb,float maxSpd = 2.0f)
	{
		Vector3 velocity;

		if (Random.Range(0, 19) < 2)//20% to not move
		{
			velocity = Vector3.zero;
		}
		else
		{
			velocity = new Vector3(Random.Range(-maxSpd, maxSpd), 0.0f, Random.Range(-maxSpd, maxSpd));
		}

		SimpleMoving(obj, rb, velocity);
	}

	static public void SimpleMoving(GameObject obj, Rigidbody rb, Vector3 velocity)
	{
		rb.velocity = velocity;
		obj.transform.rotation = Quaternion.LookRotation(velocity);
	}

}
