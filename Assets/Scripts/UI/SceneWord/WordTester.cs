using System;
using System.Collections.Generic;
using UnityEngine;

namespace TypingGame
{
    [System.Serializable]
    public class Content
    {
        public string nameEN;
        public string nameKO;

        public Content(string _nameEN, string _nameKO)
        {
            nameEN = _nameEN;
            nameKO = _nameKO;
        }
    }

    public class WordTester : MonoBehaviour
    {
        private Dictionary<string, Content> content = new Dictionary<string, Content>();

        private void Awake()
        {
            
        }
        
        public void Init()
        {
            content.Add("id-1", new Content("apple", "사과"));
            content.Add("id-2", new Content("book", "책"));
            content.Add("id-3", new Content("school", "학교"));
            content.Add("id-4", new Content("friend", "친구"));
        }

        public string GetEnglishByID(string _id)
        {
            return content.ContainsKey(_id) ? content[_id].nameEN : "";
        }

        public string GetKoreanByID(string _id)
        {
            return content.ContainsKey(_id) ? content[_id].nameKO : "";
        }
    
    
    }    
}