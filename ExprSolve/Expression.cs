using System;
using System.Collections.Generic;

namespace ExprSolve
{
    public class Action
    {
        enum type
        {
            add,
            sub,
            mult,
            div,
            pow,
            sqrt
        }

        int v1pos;
        int v2pos;

        int outpos;
    }

    public class Expression
    {
        Action[] actions;

        int[] memory;
        public Expression(string expr)
        {
            
        }
    }
}
