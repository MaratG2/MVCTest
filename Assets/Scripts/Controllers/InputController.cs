using Game.Models;
using UnityEngine;

namespace Game.Controllers
{
    public class InputController
    {
        private readonly InputModel _model;

        public InputController(InputModel model)
        {
            _model = model;
        }

        public void ManagedUpdate()
        {
            _model.verticalInput = 0f;
            _model.horizontalInput = 0f;

            if (Input.GetKeyDown(KeyCode.W))
                _model.verticalInput = 1f;
            if (Input.GetKey(KeyCode.A))
                _model.horizontalInput = -1;
            if (Input.GetKey(KeyCode.D))
                _model.horizontalInput = 1;
        }

        public float GetHorizontal()
        {
            return _model.horizontalInput;
        }

        public float GetVertical()
        {
            return _model.verticalInput;
        }

        public bool IsVertical()
        {
            return GetVertical().Equals(1f);
        }
    }
}