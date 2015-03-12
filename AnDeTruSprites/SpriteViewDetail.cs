﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace AnDeTruSprites
{
    public class SpriteViewDetail
    {
        public Texture2D LiveTexture { get; set; }
        public Texture2D DeadTexture { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
    }
}
