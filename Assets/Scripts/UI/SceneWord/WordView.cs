using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TypingGame
{
    public class WordView : MonoBehaviour
    {
        private TextMeshProUGUI textTyping;
        private TextMeshProUGUI textTarget;


        public void Init()
        {
            
        }

        void Awake()
        {
            
            
        }
        
        public void SetTyping(char _c)
        {
            textTyping.text += _c.ToString();
        }
    }
}