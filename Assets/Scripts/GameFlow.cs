using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    private static GameFlow _instance;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}