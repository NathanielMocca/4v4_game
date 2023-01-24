using UnityEngine;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace Mocca {

    public class Request
    {
        private static Request requestInstance;
        private static readonly object instancelock = new object();

        public delegate void ActionLoginCallback(bool isSuccess, string message = "");

        public static Request GetInstance()
        {
            if (requestInstance == null)
            {
                lock (instancelock)
                {
                    if (requestInstance == null)
                    {
                        requestInstance = new Request();
                    }

                    return requestInstance;
                }
            }
            else
            {
                return requestInstance;
            }
        }

        private string basePath = "http://192.168.1.105:8080"; //"http://localhost:8080";

        private RequestHelper currentRequest;


        private void LogMessage(string title, string message)
        {
            //#if UNITY_EDITOR
            //		EditorUtility.DisplayDialog (title, message, "Ok");
            //#else
            Debug.Log("[" + title + "]: \t"+ message);
            //#endif
        }

        public void SetPath(string path)
        {
            this.basePath = path;
        }

        public void Login(string name , ActionLoginCallback callback)
        {
            //RestClient.DefaultRequestParams["name"] = "Player";
            currentRequest = new RequestHelper
            {
                Uri = basePath + "/login",
                Params = new Dictionary<string, string>(),
                Body = new LoginPostBody
                {
                    userName = name
                },
                Timeout = 30,
                EnableDebug = true
            };
            RestClient.Post<LoginResponse>(currentRequest).Then(res =>
            {
                RestClient.ClearDefaultParams();
                this.LogMessage("Success", JsonUtility.ToJson(res, true));
                PlayerPrefs.SetString("token", res.token);
                callback(true, res.token);
            }).Catch(err => {
                this.LogMessage("[LoginError]", err.Message);
                callback(false, err.Message);
                });

        }

        


    }
}