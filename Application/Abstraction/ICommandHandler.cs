namespace Application.Abstraction
{
    public interface ICommandHandler<CommandType>
    {
        public void Handle(CommandType command);
    }
}
