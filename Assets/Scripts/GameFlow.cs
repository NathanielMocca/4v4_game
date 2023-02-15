using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mocca
{
    public class GameFlow : MonoBehaviour
    {
        private static GameFlow _instance;

        private GameStatus _status = GameStatus.WAITING;

        public static GameFlow Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("GameFlow");
                    go.AddComponent<GameFlow>();
                }

                return _instance;
            }
        }

        void Awake()
        {
            _instance = this;

            DontDestroyOnLoad(this.gameObject);
        }

        public GameStatus GetGameStatus()
        {
            return _status;
        }
    }


    public enum GameStatus
    {
        
        /** user qty in the game < 4 */
        WAITING ,

        /** user qty in the game >= 4*/
        READY_TO_START ,

        // client only
        DEALING_CARDS,

        /** 4 random words was sent to each team */
        READY_TO_PICK_CODE ,

        /** wait for user with secret code to present  */
        WAIT_FOR_PRESENT ,

        /** wait for rival answer the secret code */
        WAIT_FOR_RIVAL_ANS,

        /** wait for taemmate answer the secret code */
        WAIT_FOR_TEAMMATE_ANS,

        /** score each team and ready for next round or game over */
        ANS_REVEALED ,

        /** while any team got 2 award or 2 failed ends the game */
        GAME_OVER ,

        /*
        Waiting = 0, //等待人數到齊
        ReadyToStart = 1, //人數已夠，等待任意玩家開場
        DealingCards = 2, //發牌
        PickingCard = 3, //等待玩家抽卡
        WaitForStatement = 4, //等待抽卡玩家描述卡片
        WaitForAns1 = 5, //敵隊回答時間
        WaitForAns2 = 6, //我隊回答時間
        AnswerRevealed = 7, //揭曉本次抽卡答案並計分
        GameComplete = 8 //計分若任一方贏即結束
        */
    }
}