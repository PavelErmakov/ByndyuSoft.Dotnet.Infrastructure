namespace Mvc4Sample.Web.Application.Account.Criteria
{
    using ByndyuSoft.Infrastructure.Domain;

    public class FindByLogin : ICriterion
    {
        public string Login { get; set; }
    }
}