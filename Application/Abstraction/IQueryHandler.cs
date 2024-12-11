namespace Application.Abstraction
{
    public interface IQueryHandler<QueryType, QueryResponse>
    {
        public QueryResponse Handle(QueryType query);
    }
}
