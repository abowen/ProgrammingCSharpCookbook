using System.Collections.Generic;
using System.Linq;
using CSharpCookbook.BaseCommands;
using CSharpCookbook.SqlFu;

namespace CSharpCookbook.ImplementDataAccess.Linq.General
{
    public class JoinPerformanceCommand : DemoCommand
    {
        public JoinPerformanceCommand()
        {
            AddResource("Join over SelectMany", "C# In A NutShell, Location 17134");
        }

        public override string Description
        {
            get { return "Join over SelectMany Performance"; }
        }

        public override void ExecuteDemo()
        {
            var repository = new MySqlFu();
            _persons = repository.QueryPerson();
            _purchases = repository.QueryPurchase();

            PerformanceTest(JoinPerformance);
            PerformanceTest(SelectManyPerformance);
        }

        private IEnumerable<Person> _persons;
        private IEnumerable<Purchase> _purchases;

        private void JoinPerformance()
        {
            var query = from person in _persons
                        join purchase in _purchases on person.Id equals purchase.PersonId
                        select person.FirstName + " paid a " + purchase.Price;
            query.ToList();
        }

        private void SelectManyPerformance()
        {
            var query = from person in _persons
                        from purchase in _purchases where person.Id == purchase.PersonId                        
                        select person.FirstName + " paid a " + purchase.Price;
            query.ToList();
        }
    }
}

