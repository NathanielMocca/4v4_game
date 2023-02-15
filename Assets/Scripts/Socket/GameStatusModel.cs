using System;
using System.Collections.Generic;

namespace Mocca
{
    [Serializable]
    public class GameStatusModel
    {
        public string gameId;
        public string status;
        public List<Score> scores;
        public List<User> users;
        public List<Round> rounds;
    }
    [Serializable]
    public class Score
    {
        public string team;
        public int award;
        public int failed;
    }

    [Serializable]
    public class User
    {
        public string id;
        public string name;
        public string team;
    }

    [Serializable]
    public class Round
    {
        public int seqNo;
        public string id;
        public string presentTeam;
        public string presenter;
        public List<string> presentations;
        public string teammateAnswers;
        public string rivalAns;
        public List<string> repliers;
    }

}