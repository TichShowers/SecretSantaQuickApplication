using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Santa
{
    public static class SecretSantaLogic
    {
        public static void ShuffleAssignees(this IList<Person> target)
        {
            var copy = new List<Person>(target);

            var firstPerson = copy.GetRandomElement();
            copy.Remove(firstPerson);

            var assignee = copy.GetRandomElement();
            firstPerson.Assigned = assignee;

            while (copy.Count() > 1)
            {
                copy.Remove(assignee);
                var newAssignee = copy.GetRandomElement();

                assignee.Assigned = newAssignee;
                assignee = newAssignee;
            }

            assignee.Assigned = firstPerson;
        }

        private static T GetRandomElement<T>(this IList<T> target)
        {
            var random = new Random();

            return target.ElementAt(random.Next(0, target.Count()));
        }
    }
}
