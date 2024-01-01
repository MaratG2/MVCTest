using Game.Views;
using UnityEngine;

namespace Game.Core
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private View _marioView;
        [SerializeField] private View _coinView;
        [SerializeField] private View _coinTextView;

        private void Awake()
        {
            _marioView.Setup();
            _coinView.Setup();
            _coinTextView.Setup();
        }
    }
}