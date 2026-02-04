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
        private Content content;
        
        private char[] targetArray;
        
        private WordTester wordTester;
        

        private void Awake()
        {
            wordTester.Init();
            content.nameEN = wordTester.GetEnglishByID("id-1");
        }

        public char[] GetTargetChars(ELanguageSupport language)
        {
            char[] charArray = content.nameEN.ToCharArray();
            targetArray = new char[charArray.Length];
            return charArray;
        }
    }
}