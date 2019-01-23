using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Breakout
{
    public class Paddle
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public float Speed { get; set; }

        private const string IMAGE_PATH = "images/paddle";

        private const int STARTING_X = 935;
        private const int STARTING_Y = 900;
        private const float STARTING_SPEED = 400f;

        public Paddle(ContentManager content)
        {
            this.Position = new Vector2(STARTING_X, STARTING_Y);
            this.Speed = STARTING_SPEED;
            this.Texture = content.Load<Texture2D>(IMAGE_PATH);
        }

        public void Update(GameTime gameTime, KeyboardState keyboardState)
        {
            bool isLeft = keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A);
            bool isRight = keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D);
            if (isLeft ^ isRight)
            {
                Vector2 direction = isLeft ? -Vector2.UnitX : Vector2.UnitX;
                float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
                Vector2 velocity = this.Speed * direction * dt;
                this.Position += velocity;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
