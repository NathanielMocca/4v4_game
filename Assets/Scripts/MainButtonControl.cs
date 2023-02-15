using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mocca
{
    public class MainButtonControl : MonoBehaviour
    {
        public Button mainButton;
        public GameObject loading;
        public CardsController CardsController;

        // Start is called before the first frame update
        void Start()
        {
            mainButton.onClick.AddListener(mainButtonOnClick);
        }

        void loadingOn()
        {
            loading.SetActive(true);
            mainButton.enabled = false;
        }

        void loadingOff()
        {
            loading.SetActive(false);
            mainButton.enabled = true;
        }

        void mainButtonOnClick()
        {
            Debug.Log("mainButtonClicked");

            //TODO switch case
            var status = GameFlow.Instance.GetGameStatus();
            Debug.Log("[Game Status] " + status.ToString());
            switch (status)
            {
                case GameStatus.WAITING:
                    CardsController.SetCardText(0, "變變變"); //TODO
                    break;
                case GameStatus.READY_TO_START:
                    break;
                case GameStatus.READY_TO_PICK_CODE:
                    break;
                case GameStatus.WAIT_FOR_PRESENT:
                    break;
                case GameStatus.WAIT_FOR_RIVAL_ANS:
                    break;
                case GameStatus.WAIT_FOR_TEAMMATE_ANS:
                    break;
                case GameStatus.ANS_REVEALED: //to pickingcard or compelete. 
                    break;
                case GameStatus.GAME_OVER:
                    break;

            }

        }
    }
}