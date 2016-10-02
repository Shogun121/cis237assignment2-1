/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            if(maze[xStart, yStart] == ',')
            {
                //maze[lastX,lastY]= "X";
                Console.Write(maze);
            }
            else
            {
                mazeTraversal(xStart,yStart);
                Console.Write(maze);
            }
            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }
        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(int CurrentX, int CurrentY)
        {   //method used to iterate through the maze using recursion.
            int currentX = CurrentX;            //current location
            int currentY = CurrentY;

            //int lastX = LastX;                  //previous location
            //int lastY = LastY;
   
            //Implement maze traversal recursive call
            if (maze[currentX + 1, currentY] =='.')
            {   
                //place 'X' at current location.
                maze[currentX, currentY] = 'X';

                //move right
                currentX += 1;

                //print maze after step has been taken before recursion calls again.
                Console.Write(maze);

                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX, currentY + 1]=='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move up
                currentY += 1;

                //print maze after step has been taken before recursion calls again.
                Console.Write(maze);

                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX - 1, currentY] =='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move left
                currentX -= 1;

                //print maze after step has been taken before recursion calls again.
                Console.Write(maze);

                mazeTraversal(currentX, currentY);
            }
            if(maze[currentX, currentY - 1]=='.')
            {   //place 'X' at current location.
                maze[currentX, currentY] = 'X';
                
                //move down
                currentY -= 1;

                //print maze after step has been taken before recursion calls again.
                Console.Write(maze);

                mazeTraversal(currentX, currentY);
            }
            else
            {   //remove and use as a return statement
                //go back, mark spot with "o"
                maze[currentX, currentY] ='O';

            }
        }
        public void PrintMaze(char[,] maze)
        {
            this.maze = maze;
            (foreach x in this.maze)
            {

            }

        }
    }
}           //MAKE SURE TO ADD PRINT CALLS FOR EVERY MOVE
            //ADD 'X's and 'O's IN MAZE TRAVERSAL
