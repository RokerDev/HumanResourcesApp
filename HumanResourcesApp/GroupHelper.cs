using System.Collections.Generic;

namespace HumanResourcesApp
{
    class GroupHelper
    {
        public static List<Group> GetGroupsData()
        {
            return new List<Group>
            {
                new Group
                {
                    Id = 0,
                    Name = "All"
                },
                new Group
                {
                    Id = 1,
                    Name = "Hired"
                },
                new Group
                {
                    Id = 2,
                    Name = "Fired"
                }
            };
        }
    }
}
