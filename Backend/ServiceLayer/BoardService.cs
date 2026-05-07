using System;

namespace Backend.ServiceLayer
{
    /// <summary>
    /// Handles all board and column management operations.
    /// </summary>
    public class BoardService
    {
        /// <summary>
        /// Creates a new board for a specific user.
        /// </summary>
        /// <param name="email">The email of the user creating the board.</param>
        /// <param name="boardName">The name of the new board.</param>
        /// <returns>A JSON string representing success or an error message.</returns>
        public string CreateBoard(string email, string boardName)
        {
            return null;
        }

        /// <summary>
        /// Deletes an existing board. Only the owner can delete.
        /// </summary>
        /// <param name="email">The email of the user attempting to delete.</param>
        /// <param name="boardName">The name of the board to delete.</param>
        /// <returns>A JSON string representing success or an error message.</returns>
        public string DeleteBoard(string email, string boardName)
        {
            return null;
        }

        /// <summary>
        /// Adds a user as a member to an existing board.
        /// </summary>
        /// <param name="email">The email of the user joining.</param>
        /// <param name="boardID">The unique ID of the board.</param>
        /// <returns>A JSON string representing success or an error message.</returns>
        public string JoinBoard(string email, int boardID)
        {
            return null;
        }

        /// <summary>
        /// Removes a user from the membership of a board.
        /// </summary>
        /// <param name="email">The email of the user leaving.</param>
        /// <param name="boardID">The unique ID of the board.</param>
        /// <returns>A JSON string representing success or an error message.</returns>
        public string LeaveBoard(string email, int boardID)
        {
            return null;
        }

        /// <summary>
        /// Sets a limit for the number of tasks in a specific column.
        /// </summary>
        /// <param name="email">The user's email.</param>
        /// <param name="boardName">The board name.</param>
        /// <param name="columnOrdinal">The column index (0-backlog, 1-in progress, 2-done).</param>
        /// <param name="limit">The maximum number of tasks.</param>
        /// <returns>A JSON string representing success or an error message.</returns>
        public string LimitColumn(string email, string boardName, int columnOrdinal, int limit)
        {
            return null;
        }
    }
}
