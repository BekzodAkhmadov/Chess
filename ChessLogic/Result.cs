using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic;

public class Result(Player winner, EndReason reason)
{
    public Player Winner { get; } = winner;
    public EndReason Reason { get; } = reason;

    public static Result Win(Player winner) 
    {
        return new Result(winner, EndReason.Chackmate);
    }

    public static Result Draw(EndReason reason) 
    {
        return new Result(Player.None, reason);
    }
}
