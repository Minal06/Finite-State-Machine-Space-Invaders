using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


namespace SI
{
    public class GameSystem : StateMachine
    {
        #region Fields and settings for STATES + Getters
        [Header("References to UI, Enemy, Player functions")]
        [SerializeField] private CanvasSetup canvasSetup;                  
        [SerializeField] private PlayerController player;
        [SerializeField] private EnemySetup enemyHolder;
        
        //Getters
        public PlayerController Player => player;
        public EnemySetup Enemy => enemyHolder;
        public CanvasSetup Canvas => canvasSetup;      

        #endregion

        #region Singleton
        public static GameSystem SharedInstance { get; private set; }

        private void Awake()
        {
            if (SharedInstance != null)
            {
                Destroy(gameObject);
                return;
            }
            SharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        #endregion

        // Start is called before the first frame update
        void Start()
        {                        
            SetState(new BeginGame(this));
        }

        // Update is called once per frame
        void Update()
        {
            State.UpdateState();
        }


        #region Menu buttons
        public void StartButton()
        {
            State.ExitState();
        }
        public void Exit()
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        }
        #endregion
    }
}