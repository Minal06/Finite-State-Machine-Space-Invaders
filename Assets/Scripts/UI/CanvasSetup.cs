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
        [SerializeField] private GameObject youWon;
        [SerializeField] private GameObject youLost;
        public TextMeshPro timer;
                       

        private void Start()
        {            
        }


        public void GoCanvas(bool t)
        {           
            canvas.SetActive(t);
        }

        public void StartScrn(bool t)
        {
            startButton.SetActive(t);
        }
        public void ExitButton(bool t)
        {
            exitButton.SetActive(t);
        }

        public void PauseScrn(bool t)
        {
            resumeButton.SetActive(t);            
        }

        public void PreparationScrn(bool t)
        {
            preparationInfo.SetActive(t);
        }
        
        public void YouWon(bool t)
        {
            GoCanvas(t);
            ExitButton(t);
            youWon.SetActive(t);

        }
        public void YouLost(bool t)
        {
            GoCanvas(t);
            ExitButton(t);
            youLost.SetActive(t);

        }
    }
}