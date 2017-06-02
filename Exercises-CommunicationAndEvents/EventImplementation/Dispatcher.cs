namespace EventImplementation
{
    public delegate void NameChangeEventHandler();

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        public string Name { get; private set; }

        public void OnNameChange(NameChangeEventArgs args)
        {
            this.NameChange += this.DispatcherNameChange;
        }

        private void DispatcherNameChange()
        {
        }
    }
}