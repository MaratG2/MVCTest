namespace Game.Models
{
    public class MovementModel
    {
        public float speed;
        public float jumpStrength;

        public MovementModel(float newSpeed, float newJumpStrength)
        {
            speed = newSpeed;
            jumpStrength = newJumpStrength;
        }
    }
}