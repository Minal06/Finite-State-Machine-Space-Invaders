using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class GameSystem : StateMachine
    {
        #region Fields and settings
        private

        #endregion
        // Start is called before the first frame update
        void Start()
        {
            SetState(new BeginGame(this));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}