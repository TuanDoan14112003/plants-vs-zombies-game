﻿using System;
namespace PlantsVsZombies
{
    public class ZombieEatingState : ZombieState
    {
        public Texture2D GetTexture(Zombie zombie) { return zombie.EatingTexture; }
    


        public void Update(GameTime gameTime, Zombie zombie)
        {

            if (zombie.SoundInstance.State != SoundState.Playing)
                zombie.SoundInstance.Play();
            
        }
    }
}

