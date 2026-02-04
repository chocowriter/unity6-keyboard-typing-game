using System;
using UnityEngine;

namespace TypingGame
{
    public enum ELanguageSupport
    {
        English = 0,
        Korean = 1
    }
    
    public class WordModel : MonoBehaviour
    {
        [SerializeField] private Content content;
        
        private char[] targetArray;
        
        //private WordTester wordTester;
        

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
        }

        public char[] GetTargetChars(ELanguageSupport language)
        {
            char[] charArray = content.nameEN.ToCharArray();
            targetArray = new char[charArray.Length];
            return charArray;
        }
    }
}