using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mocca
{
    public class MenuController : MonoBehaviour
    {
        public Button playButton;
        public Button optionButton;
        public TMP_InputField uriInput;
        public TMP_InputField nameInput;
        public GameObject loading;


        // Start is called before the first frame update
        void Start()
        {
            uriInput.text = "http://192.168.1.105:8080";
            playButton.onClick.AddListener(playButtonOnClick);
            optionButton.onClick.AddListener(optionButtonOnClick);
            string player = PlayerPrefs.GetString("name");
            if (!string.IsNullOrEmpty(player)) nameInput.text = player; 
        }

        // Update is called once per frame
        void Update()
        {

        }

        void playButtonOnClick()
        {
            Debug.Log("You have clicked the button!");
            PlayerPrefs.SetString("name", nameInput.text);
            Request.GetInstance().SetPath(uriInput.text);

            Debug.Log("[PlayerPref] name= " + PlayerPrefs.GetString("name"));
            loadingOn();
            Request.GetInstance().Login(PlayerPrefs.GetString("name"), LoginCallback);
        }
        void optionButtonOnClick()
        {
            Debug.Log("You have clicked the button!");
        }

        public void loadingOn()
        {
            loading.SetActive(true);
            playButton.enabled = false;
            optionButton.enabled = false;
        }

        public void loadingOff()
        {
            loading.SetActive(false);
            playButton.enabled = true;
            playButton.enabled = true;
        }

        private void LoginCallback(bool isSuccess,string msg)
        {
            loadingOff();
            //TODO
            //is success Go To Next Scene
        }
    }
}
