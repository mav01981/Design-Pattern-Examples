
using System;
using System.Collections.Generic;

namespace CQRS
{
    //CQRS Command Query responsibillity segregration
    //CQS Command Query Segregration

    //COMMAND -db/Change
    public class Person
    {
        public int age;
        EventBroker broker;

        public Person(EventBroker broker)
        {
            this.broker = broker; // publisher
            broker.Commands += BrokerCommands; //subscriber
            broker.Querys += BrokerQuerys; //subscriber
        }

        private void BrokerQuerys(object sender, Query e)
        {
            var c = e as AgeQuery;
            if (c != null && c.Target == this)
            {
                c.Result = age;
            }
        }
    

        private void BrokerCommands(object sender, Command command)
        {
            var c = command as ChangeAgeCommand;
            if (c != null && c.Target == this)
            {
                broker.allevents.Add(new AgeChangedEvent(c.Target, c.Age, age));
                age = c.Age;
            }
        }
    }

    public class Command
    {

    }
    public class Event
    {

    }

    public class AgeChangedEvent : Event
    {
        public Person Target;
        public int NewValue, Oldvalue;

        public AgeChangedEvent(Person target, int newValue, int oldvalue)
        {
            Target = target;
            NewValue = newValue;
            Oldvalue = oldvalue;
        }
        public override string ToString()
        {
            return $"Age change from {Oldvalue} to {NewValue}";
        }
    }

    public class Query
    {
        public Object Result;
    }
    class AgeQuery : Query
    {
        public Person Target;
    }
    class ChangeAgeCommand : Command
    {
        public Person Target;
        public int Age;
        public ChangeAgeCommand(Person target, int age)
        {
            Target = target;
            Age = age;
        }
    }
    public class EventBroker
    {
        //1.All events that happend.
        //
        public IList<Event> allevents = new List<Event>();
        //Commands
        public event EventHandler<Command> Commands; //delegate
        //Query
        public event EventHandler<Query> Querys; ///delegate
        /// 
        /// </summary>
        /// <param name="c"></param>

        public void Command(Command c)
        {
            Commands?.Invoke(this, c);
        }

        public T Query<T>(Query q)
        {
            Querys?.Invoke(this, q);
            return (T)q.Result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var bus = new EventBroker();
            var p = new Person(bus);
            bus.Command(new ChangeAgeCommand(p, 10));

            int age = bus.Query<int>(new AgeQuery { Target = p });

            Console.WriteLine(age);

            foreach(var e in bus.allevents)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
