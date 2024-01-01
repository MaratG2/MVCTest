using Game.Controllers;
using Game.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Views
{
    public class CoinTextView : View
    {
        [SerializeField] private Text _coinTMP;
        private CoinTextController _textController;

        public override void Setup()
        {
            _textController = new CoinTextController(new CoinTextModel());
            RefreshText();
        }

        private void OnEnable()
        {
            CoinView.OnCoinTook += CoinTook;
        }

        private void OnDisable()
        {
            CoinView.OnCoinTook -= CoinTook;
        }

        public void CoinTook(int quantity)
        {
            _textController.AddCoinCount(quantity);
            RefreshText();
        }

        private void RefreshText()
        {
            _coinTMP.text = $"Coins: {_textController.GetCoinCount()}";
        }
    }
}