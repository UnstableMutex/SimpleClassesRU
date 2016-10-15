namespace SimpleClasses
{
    public interface IReadOnlySimpleFIO
    {
        string Abbr { get; }
        /// <summary>
        /// Имя
        /// </summary>
        string FirstName { get;  }
        string Full { get; }
        /// <summary>
        /// Отчество
        /// </summary>
        string Patronymic { get; }
        /// <summary>
        /// Фамилия
        /// </summary>
        string Surname { get; }
    }
}