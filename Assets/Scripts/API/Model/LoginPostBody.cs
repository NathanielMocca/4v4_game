using System;

namespace Mocca
{
    [Serializable]
	public class LoginPostBody
	{
		//public int id;

		//public int userId;

		public string userName;

		//public string body;

		public override string ToString(){
			return UnityEngine.JsonUtility.ToJson (this, true);
		}
	}
}