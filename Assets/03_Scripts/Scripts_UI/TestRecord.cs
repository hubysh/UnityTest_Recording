using UnityEngine;
using System.Collections;

public class TestRecord : MonoBehaviour
{
	public Vector3 position = new Vector3(0,0,0);

	void Click\RecordButton()
	{
		position.Set(position.x + 10, position.y + 10, position.z); 
		Singleton.Instance.cydSample.transform.position = position;

		Debug.Log(Singleton.Instance.cydSample.transform.position.ToString());
		
	}
}
