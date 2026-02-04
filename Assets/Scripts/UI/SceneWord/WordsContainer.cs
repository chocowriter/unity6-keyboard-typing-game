using System;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

namespace TypingGame
{
    public class WordsContainer : BaseSingleton<WordsContainer>
    {
        public Dictionary<string, string> englishWords = new Dictionary<string, string>();
        
        private void Awake()
        {
            Init();
        }

        void Init()
        {
            // content.Add("id-1", new Content("apple", "사과"));
            // content.Add("id-2", new Content("book", "책"));
            // content.Add("id-3", new Content("school", "학교"));
            // content.Add("id-4", new Content("friend", "친구"));
            
            //englishWords.Add();
        }
            
    }    
}