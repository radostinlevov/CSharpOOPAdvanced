namespace EventImmplementationToMyWay
{
    using System;

    public class Dispatcher
    {
        public Dispatcher(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public event EventHandler EventHandler;

        public void ChangeName()
        {
            EventHandler += DispatcherEventHandler;
            EventHandler.Invoke(this, EventArgs.Empty);
        }

        private void DispatcherEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Dispatcher's name changed to {this.Name}.");
        }
    }
}