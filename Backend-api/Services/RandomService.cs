﻿namespace Backend_api.Services
{
    public class RandomService : IRandomService 
    {
        private readonly int _value;

        public int Value
        {
            get => _value;
        }

        public RandomService() 
        {
            _value = new Random().Next(100);
        }
    }
}
