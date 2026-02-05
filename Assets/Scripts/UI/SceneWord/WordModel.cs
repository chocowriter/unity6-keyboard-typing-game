using System;
using UnityEngine;

namespace TypingGame
{
    public enum ELanguage
    {
        English = 0,
        Korean = 1
    }
    
    public class WordModel : MonoBehaviour
    {
        private string targetString = "sample";
        private char[] targetArray;
        
        private string inputString = "";
        
        private void Awake()
        {
            Init();
        }

        private void Start()
        {
            
        }

        public void Init()
        {
            targetArray = targetString.ToCharArray();
            inputString = "";
        }
        
        public string GetTargetString()
        {
            return targetString;
        }
        
        public char GetTargetCharacter(int _index)
        {
            return targetArray[_index];
        }

        public void SetKeyInput(string _input)
        {
            inputString += _input;
        }

        public string GetInputString()
        {
            return inputString;
        }
    }
}