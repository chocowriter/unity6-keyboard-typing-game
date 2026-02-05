using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TypingGame
{
    public class WordController : MonoBehaviour
    {
        private WordModel model;
        private WordView view;
        private char inputKey;
        private int index = 0;

        private void Awake()
        {
            model = GetComponent<WordModel>();
            view = GetComponent<WordView>();
        }

        public void Init()
        {
            Keyboard.current.onTextInput += c =>
            {
                Debug.Log(c);
                index++;
                inputKey = c;
                view.SetTyping(c);
            };
        }

        public void CheckIfMatch()
        {
            if (model.GetTargetCharacter(index) == inputKey)
            {
                
            }
            else
            {
                
            }
        }
    }
}