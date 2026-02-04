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
        private Content contentTarget;
        private Content contentTyping;

        private char[] targetArray;
        private char[] typingArray;

        private void Awake()
        {
            
        }

        public char[] GetTargetChars(ELanguageSupport language)
        {
            
            char[] charArray = contentTarget.nameEN.ToCharArray();
            targetArray = new char[charArray.Length];
            typingArray = new char[charArray.Length];
            
            return charArray;
        }

        public char[] GetTypingChars(ELanguageSupport language)
        {
            char[] charArray = contentTyping.nameEN.ToCharArray();
            return charArray;
        }
    }
}