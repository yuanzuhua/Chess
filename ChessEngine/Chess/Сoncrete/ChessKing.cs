﻿using System.Drawing;

namespace Chess
{
    public class ChessKing : Chess
    {
        public ChessKing( ChessFactory factory, GameColor color )
            :   base( factory, color, ChessType.King )
        {
        }

        protected override bool CanMoveInternal( Point index )
        {
            if (    Cell.Index.X - 1 <= index.X
                &&  Cell.Index.X + 1 >= index.X
                &&  Cell.Index.Y - 1 <= index.Y
                &&  Cell.Index.Y + 1 >= index.Y )
                return CheckMove( index ) && CheckMayDie( Cell.Index );
            return false;
        }
    }
}
