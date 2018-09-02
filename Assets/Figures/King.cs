﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Figures
{
    public class King : ChessFigure
    {
        public override IEnumerable<BoardCell> MovementCells
        {
            get
            {
                var offsets = new[]
                {
                    Vector2Int.up,
                    Vector2Int.down,
                    Vector2Int.left,
                    Vector2Int.right,
                    Vector2Int.right + Vector2Int.up,
                    Vector2Int.right + Vector2Int.down,
                    Vector2Int.left + Vector2Int.down,
                    Vector2Int.left + Vector2Int.up
                };
                var positions = offsets.Select(offset => Position + offset);
                return AvailableMovementCells(positions);
            }
        }

        public override int Value
        {
            get { return 1000; }
        }
    }
}