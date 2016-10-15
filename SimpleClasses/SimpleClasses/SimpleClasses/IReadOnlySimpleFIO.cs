namespace SimpleClasses
{
    public interface IReadOnlySimpleFIO
    {
        string Abbr { get; }
        string FirstName { get;  }
        string Full { get; }
        string Patronymic { get; }
        string Surname { get; }
    }
}