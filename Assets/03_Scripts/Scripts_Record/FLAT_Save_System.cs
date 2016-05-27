using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;


public class FLAT_Save_System : MonoBehaviour
{
	// 저장하고 로드할 파일의 이름
	public string sFileName;
	// 저장, 로드에 사용할 디렉터리 이름
	public string sDirectory;

	public GameObject Player;

	void WriteToFile(string file = "")
	{
		if (file !="")
		{
			sFileName = file;
		}

		if (File.Exists(sDirectory + sFileName))
		{
			DeleteFile(sFileName);
		}

		using (StreamWriter sw = new StreamWriter(sDirectory + sFileName))
		{
			sw.WriteLine(PlayerPrefs.GetInt("PlayerKills").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerDeaths").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerTotalGold").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerCurrentGold").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerGoldSpent").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerLevel").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerRoundsWon").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayterRoundLost").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerKDR").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerWLR").ToString());
			sw.WriteLine(PlayerPrefs.GetInt("PlayerTimePlayed").ToString());
			//sw.WriteLine(Player.transform.position.x.ToString());
			//sw.WriteLine(Player.transform.position.y.ToString());
			//sw.WriteLine(Player.transform.position.z.ToString());



		}
	}

	private void DeleteFile(string file = "")
	{
		File.Delete(sDirectory + file);
	}
}
