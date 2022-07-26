using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SI
{
    public class CanvasSetup : MonoBehaviour
    {
        [SerializeField] GameObject startButton;
        [SerializeField] GameObject resumeButton;
        [SerializeField] GameObject exitButton;
        [SerializeField] GameObject canvas;
        bool isCanvas = false;

        private void Start()
        {            
        }


        public void GoCanvas()
        {
            isCanvas = !isCanvas;
            canvas.SetActive(isCanvas);
        }

        public void StartScrn()
        {
            startButton.SetActive(isCanvas);
        }
        
    }
}