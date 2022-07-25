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
        #region Fields and settings
        [Header("UI and Buttons")]
        public GameObject _canvas;
        public GameObject startButton;
        public GameObject resumeButton;
        public GameObject exitButton;
        bool isCanvas;


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


        public void GoCanvas() 
        {
            isCanvas = !isCanvas;
            _canvas.SetActive(isCanvas);
        }

        #region StartMenu buttons
        public void StartButton()
        {
            StartCoroutine(State.ExitState());
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