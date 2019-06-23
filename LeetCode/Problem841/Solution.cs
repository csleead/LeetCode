using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem841
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var locked = new bool[rooms.Count];
            Array.Fill(locked, true);
            locked[0] = false;

            var visited = new bool[rooms.Count];
            Array.Fill(visited, false);

            var roomsToVisit = new Queue<int>();
            roomsToVisit.Enqueue(0);
            while(roomsToVisit.Count > 0)
            {
                var room = roomsToVisit.Dequeue();
                if(visited[room])
                    continue;

                visited[room] = true;

                if(locked[room])
                    return false;

                foreach(var key in rooms[room])
                {
                    locked[key] = false;
                    roomsToVisit.Enqueue(key);
                }
            }

            return locked.All(b => b == false);
        }
    }
}
