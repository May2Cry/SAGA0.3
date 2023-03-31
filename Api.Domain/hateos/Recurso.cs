namespace SAGA0._3.Api.Domain.hateos
{
    public class Recurso<T>
    {
        public List<DatoHATEOAS> _links { get; set; } = new List<DatoHATEOAS>();

        public T _embedded { get; set; }
    }
}
