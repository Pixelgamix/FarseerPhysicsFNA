using FarseerPhysics.Samples.DrawingSystem;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FarseerPhysics.Samples.ScreenSystem
{
    public sealed class VirtualStick
    {
        private Sprite _socketSprite;
        private Sprite _stickSprite;
        private int _picked;
        private Vector2 _position;
        private Vector2 _center;

        public Vector2 StickPosition;

        public VirtualStick(Texture2D socket, Texture2D stick, Vector2 position)
        {
            _socketSprite = new Sprite(socket);
            _stickSprite = new Sprite(stick);
            _picked = -1;
            _center = position;
            _position = position;
            StickPosition = Vector2.Zero;
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Draw(_socketSprite.Texture, _center, null, Color.White, 0f, _socketSprite.Origin, 1f, SpriteEffects.None, 0f);
            batch.Draw(_stickSprite.Texture, _position, null, Color.White, 0f, _stickSprite.Origin, 1f, SpriteEffects.None, 0f);
        }
    }
}
