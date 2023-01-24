using System;

namespace Mocca
{
	[Serializable]
	public class LoginResponse
	{
		//public int id;

		public string token;

		//public string title;

		//public string body;

		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this, true);
		}
	}
}