// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
      

    

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Steady Hands Maze");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //CLEAR BACKGROUND
            Window.ClearBackground(240);

            //MAKING PLAYER MOUSE MOVEMENT
            Vector2 position = Input.GetMousePosition();

            //DRAWING PLAYER RED CUBE
            Draw.FillColor = Color.Red;
            Draw.Circle(position, 25);
















        }
    }

}
