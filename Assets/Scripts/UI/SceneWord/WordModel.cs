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
        //[SerializeField] private Content content;

        private string targetString = "sample";
        private char[] targetArray;
        
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
        }
        
        public string GetTargetString()
        {
            return targetString;
        }
        
        public char GetTargetCharacter(int _index)
        {
            return targetArray[_index];
        }
    }
}