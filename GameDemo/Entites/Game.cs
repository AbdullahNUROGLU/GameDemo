﻿using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entites
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}