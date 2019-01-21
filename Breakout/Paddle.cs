using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Breakout
{
    public class Paddle
    {
        public Vector2 position { get; set; }
        public Texture2D texture;

        private const string IMAGE_PATH = "images/paddle";

        private const int STARTING_X = 935;
        private const int STARTING_Y = 900;

        public Paddle(ContentManager content)
        {
            this.position = new Vector2(STARTING_X, STARTING_Y);
            this.texture = content.Load<Texture2D>(IMAGE_PATH);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.position, Color.White);
        }
    }
}
