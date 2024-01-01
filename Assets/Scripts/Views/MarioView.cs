using Game.Controllers;
using Game.Models;
using UnityEngine;

namespace Game.Views
{
    public class MarioView : View
    {
        private InputController _inputController;
        private MovementController _movementController;
        private Rigidbody2D _rb2d;

        public override void Setup()
        {
            _inputController = new InputController(new InputModel());
            _movementController = new MovementController(new MovementModel(5f, 700f));
            _rb2d = GetComponent<Rigidbody2D>();
            gameObject.transform.position = Vector3.zero;
        }

        void Update()
        {
            _inputController.ManagedUpdate();
            if (_inputController.IsVertical())
                _movementController.Jump(_rb2d, transform);

            _movementController.Move(_rb2d, _inputController.GetHorizontal());
        }
    }
}