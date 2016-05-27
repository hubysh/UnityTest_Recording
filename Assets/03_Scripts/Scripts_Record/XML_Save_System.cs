using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;


public class XML_Save_System : MonoBehaviour
{
	//PC에 있는 XML 파일의 데이터를 불러와서 담아둘 XML 문서
	XmlDocument xplayer = new XmlDocument();
	//사용할 XML  파일의 디렉터리와 확장자를 포함한 파일 이름
	public string pFileName = "";
	
	void SavePlayer()
	{
		if(Singleton.Instance.cydSample != null)
		{
			XmlNode root = xplayer.FirstChild;

			foreach (XmlNode node in root.ChildNodes)
			{
				switch (node.Name)
				{
					case "xPos":
						node.InnerText = Singleton.Instance.cydSample.transform.position.x.ToString();
						break;
					case "yPos":
						node.InnerText = Singleton.Instance.cydSample.transform.position.y.ToString();
						break;
					case "zPos":
						node.InnerText = Singleton.Instance.cydSample.transform.position.z.ToString();
						break;
				}
			}
			xplayer.Save(pFileName);
		}
	}
	
	void LoadPlayer()
	{
		float xPos = 0.00f;
		float yPos = 0.00f;
		float zPos = 0.00f;

		if (Singleton.Instance.cydSample != null)
		{
			XmlNode root = xplayer.FirstChild;
			foreach (XmlNode node in root.ChildNodes)
			{
				switch (node.Name)
				{
					case "xPos":
						xPos = Convert.ToSingle(node.InnerText);
						break;
					case "yPos":
						yPos = Convert.ToSingle(node.InnerText);
						break;
					case "zPos":
						zPos = Convert.ToSingle(node.InnerText);
						break;
				}
			}

			Singleton.Instance.cydSample.transform.position = new Vector3(xPos, yPos, zPos);
		}
	}
}
