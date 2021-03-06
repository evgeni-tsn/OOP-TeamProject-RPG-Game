﻿namespace LeGame.Models.Levels
{
    using System.Collections.Generic;

    using LeGame.Interfaces;
    using LeGame.Models.Levels.LevelAssets;

    public class Level : ILevel
    {
        public Level(string path, ICharacter player)
        {
            this.Player = player;

            this.Type = path;
            var backgroundBuilder = new LevelBuilder(path);

            this.Assets = backgroundBuilder.Background;
            this.Enemies = new List<ICharacter>();
            this.Projectiles = new List<IProjectile>();
        }

        public List<IGameObject> Assets { get; }

        public List<ICharacter> Enemies { get; }

        public ICharacter Player { get; set; }

        public List<IProjectile> Projectiles { get; }

        public string Type { get; }
    }
}