using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TypingGame
{
    public class WordController : MonoBehaviour
    {
        private WordModel model;
        private WordView view;
        private char inputKeyChar;
        private string inputKeysString;
        private int index = 0;

        private void Awake()
        {
            model = GetComponent<WordModel>();
            view = GetComponent<WordView>();
        }

        private void Start()
        {
            Init();
        }

        public void Init()
        {
            index = 0;
            
            inputKeysString = string.Empty;
            // inputKeysString = "";
            //inputKeysString = null;
            
            inputKeyChar = '\0';
            
            Keyboard.current.onTextInput += c =>
            {
                Debug.Log(c);
                index++;
                inputKeyChar = c;
                view.SetTyping(c);
            };
        }

        public bool CheckIfMatch()
        {
            if (model.GetTargetCharacter(index) == inputKeyChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIsSucceeded()
        {
            if (model.GetTargetString() == inputKeysString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}