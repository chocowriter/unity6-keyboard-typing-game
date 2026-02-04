using System;
using UnityEngine;

namespace TypingGame
{
    public class WordController : MonoBehaviour
    {
        private WordModel model;
        private ModelView view;

        private void Awake()
        {
            
        }

        private void Update()
        {
            Input.GetKeyUp();
        }
    }
}