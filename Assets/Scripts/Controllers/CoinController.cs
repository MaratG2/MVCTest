using Game.Models;

namespace Game.Controllers
{
    public class CoinController
    {
        private readonly CoinModel _model;

        public CoinController(CoinModel model)
        {
            _model = model;
        }

        public int GetCoinValue()
        {
            return _model.value;
        }
    }
}