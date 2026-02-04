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

        public bool SetTyping(char _c)
        {
            char target = model.GetTargetCharacter(0);
            if (target == _c)
            {
                textTyping.text += _c.ToString();    
            }
            else
            {
                textTarget.color = Color.red;
            }

            return true;
        }

        public void SetTarget(string _target)
        {
            //model.Target = _target;
            textTarget.text = _target;
        }
    }
}