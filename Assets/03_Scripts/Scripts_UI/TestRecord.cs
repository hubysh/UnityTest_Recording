using UnityEngine;
using System.Collections;

public class TestRecord : MonoBehaviour
{
	public Vector3 position = new Vector3(173, 240, -100);

	void ClickRecordButton()
	{
		Singleton.Instance.cydSample.transform.position = position;
		position.Set(position.x + 10, position.y + 10, position.z);
	}
	
}
