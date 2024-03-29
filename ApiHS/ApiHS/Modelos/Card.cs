﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHS
{
    public class Card
    {
            public int id { get; set; }
            public int collectible { get; set; }
            public string slug { get; set; }
            public int classId { get; set; }
            public List<object> multiClassIds { get; set; }
            public int minionTypeId { get; set; }
            public int cardTypeId { get; set; }
            public int cardSetId { get; set; }
            public int rarityId { get; set; }
            public string artistName { get; set; }
            public int health { get; set; }
            public int attack { get; set; }
            public int manaCost { get; set; }
            public string name { get; set; }
            public string text { get; set; }
            public string image { get; set; }
            public string flavorText { get; set; }
            public string cropImage { get; set; }
            public List<int> childIds { get; set; }
            public List<int> keywordIds { get; set; }
    }

        public class Root
        {
            public List<Card> cards { get; set; }
            public int cardCount { get; set; }
            public int pageCount { get; set; }
            public int page { get; set; }
        }
    }

