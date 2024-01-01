using System;
using Game.Controllers;
using Game.Models;
using UnityEngine;

namespace Game.Views
{
    public class CoinView : View
    {
        private CoinController _controller;
        public static event Action<int> OnCoinTook;
        
        public override void Setup()
        {
            _controller = new CoinController(new CoinModel());
        }
        
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                OnCoinTook?.Invoke(_controller.GetCoinValue());
                Destroy(gameObject);
            }
        }
    }
}