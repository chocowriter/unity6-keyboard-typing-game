using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TypingGame
{
    public class WordView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textTyping;
        [SerializeField] private TextMeshProUGUI textTarget;
        private WordModel model;

        void Awake()
        {
            model = GetComponentInParent<WordModel>();
            
        }

        public void Init()
        {
            
        }

        public void SetTyping(char _c)
        {
            textTyping.text += _c.ToString();
        }

        public void SetTarget(string _target)
        {
            //model.Target = _target;
            textTarget.text = _target;
        }
    }
}