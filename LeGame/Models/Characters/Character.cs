﻿using LeGame.Interfaces;
using Microsoft.Xna.Framework;

namespace LeGame.Models.Characters
{
    public abstract class Character : GameObject, ICharacter, IUseWeapon, IKillable, IMovable
    {
        protected Character(Vector2 position, string type, int maxHealth, int currentHealth, int speed, Level level)
            : base(position, type)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = currentHealth;
            this.Speed = speed;
            this.Level = level;
        }
        
        public Level Level { get; set; }

        public int MaxHealth { get; set; }

        public int CurrentHealth { get; set; }

        public int Speed { get; set; }

        public abstract void Move();

        public abstract void AttackUsingWeapon();

    }
}
