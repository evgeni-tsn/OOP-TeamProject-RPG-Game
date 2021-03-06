﻿namespace LeGame.Interfaces
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public interface IStat
    {
        SpriteFont Font { get; set; }

        void Draw(ICharacter character, SpriteBatch spriteBatch);

        void Load(ContentManager content);
    }
}