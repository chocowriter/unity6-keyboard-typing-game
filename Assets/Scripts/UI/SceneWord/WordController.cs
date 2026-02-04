using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TypingGame
{
    public class WordController : MonoBehaviour
    {
        private WordModel model;
        private WordView view;

        private void Awake()
        {
            Keyboard.current.onTextInput += c =>
            {
                Debug.Log(c);
            };
        }

        private void Update()
        {
            
        }
    }
}