using Odev5Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }

    }
}
