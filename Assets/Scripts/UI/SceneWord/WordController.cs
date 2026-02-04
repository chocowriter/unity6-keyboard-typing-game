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
            model = GetComponent<WordModel>();
            view = GetComponent<WordView>();
            
            Keyboard.current.onTextInput += c =>
            {
                Debug.Log(c);
                view.SetTyping(c);
            };
        }

        public void CheckIfMatch()
        {
            //model.
        }
    }
}