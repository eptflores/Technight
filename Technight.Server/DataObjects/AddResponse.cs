﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technight.Server.DataObjects
{
    public class AddResponse:Response
    {
        public RecipeItem Recipe { get; set; }
    }
}
