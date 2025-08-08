# Chess Game

A chess game implementation in C# using WPF for the user interface.

## Features

- Complete chess game rules implementation
- Graphical user interface with drag & drop moves 
- Custom cursors for each player
- Move highlighting
- Pawn promotion
- Castling moves
- En passant captures
- Game state tracking
- Pause menu
- Game over detection with multiple end conditions:
  - Checkmate
  - Stalemate 
  - Fifty-move rule
  - Insufficient material
  - Threefold repetition

## Technical Details

Built with:
- C# (.NET)
- WPF (Windows Presentation Foundation)
- Visual Studio

The solution consists of two projects:
- `ChessLogic`: Core game logic and rules
- `ChessUI`: WPF-based user interface

## Getting Started

1. Clone the repository
2. Open `Chess.sln` in Visual Studio 
3. Build and run the solution
4. Use left-click to select and move pieces
5. Press ESC to pause the game

## Game Controls

- Left mouse button: Select and move pieces
- ESC key: Open pause menu
