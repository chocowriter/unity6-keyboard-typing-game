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
        [SerializeField] private Content content;
        
        private char[] targetArray;
        
        //private WordTester wordTester;
        public string stringTarget;

        private void Awake()
        {
            //wordTester = GetComponent<WordTester>();
        }

        private void Start()
        {
            Init();
        }

        public void Init()
        {
            //wordTester.Init();
            content.nameEN = "banana";
            content.nameKO = "바나나";
        }

        public char[] GetTargetChars(ELanguage language)
        {
            char[] charArray = content.nameEN.ToCharArray();
            targetArray = new char[charArray.Length];
            return charArray;
        }
    }
}