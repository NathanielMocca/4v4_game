using UnityEngine;
using TMPro;

namespace Mocca
{
    public class StatusBarController : MonoBehaviour
    {
        public TMP_Text statusText;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            var status = GameFlow.Instance.GetGameStatus();
            //Debug.Log("[Game Status] " + status.ToString());
            switch (status)
            {
                case GameStatus.WAITING:
                    statusText.text = "等待人數到齊...";
                    break;
                case GameStatus.READY_TO_START:
                    statusText.text = "可開始遊戲...";
                    break;
                case GameStatus.DEALING_CARDS:
                    statusText.text = "發牌中...";
                    break;
                case GameStatus.READY_TO_PICK_CODE:
                    statusText.text = "等待玩家抽取卡片"; //TODO who 
                    break;
                case GameStatus.WAIT_FOR_PRESENT:
                    statusText.text = "玩家請陳述"; //TODO who 
                    break;
                case GameStatus.WAIT_FOR_RIVAL_ANS:
                    statusText.text = "請回答"; //TODO 哪隊
                    break;
                case GameStatus.WAIT_FOR_TEAMMATE_ANS:
                    statusText.text = "請回答"; //TODO 哪隊
                    break;
                case GameStatus.ANS_REVEALED: //to pickingcard or compelete.
                    statusText.text = "公佈答案"; //TODO 
                    break;
                case GameStatus.GAME_OVER:
                    statusText.text = "遊戲結束"; //TODO 誰贏
                    break;

            }
        }
    }
}