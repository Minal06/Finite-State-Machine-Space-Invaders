using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace SI
{
    public class CanvasSetup : MonoBehaviour
    {
        [SerializeField] private GameObject startButton;
        [SerializeField] private GameObject resumeButton;
        [SerializeField] private GameObject exitButton;
        [SerializeField] private GameObject canvas;
        [SerializeField] private GameObject preparationInfo;
        public TextMeshPro timer;
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

        public void PauseScrn()
        {
            resumeButton.SetActive(isCanvas);            
        }

        public void PreparationScrn(bool t)
        {
            preparationInfo.SetActive(t);
        }
        
    }
}