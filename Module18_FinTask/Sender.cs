namespace Module18_FinTask
{
    /// <summary>
    /// Class describes command's way
    /// </summary>
    class Sender
    {
        
        Command command;

        public void SetCommand(Command _command)
        {
            command = _command;
        }

        public void Run()
        {
            command.Run();
        }

    }
}
