using Game.Models;

namespace Game.Controllers
{
    public class CoinTextController
    {
        private readonly CoinTextModel _model;

        public CoinTextController(CoinTextModel model)
        {
            _model = model;
        }

        public void AddCoinCount(int quantity)
        {
            _model.count += quantity;
        }

        public int GetCoinCount()
        {
            return _model.count;
        }
    }
}