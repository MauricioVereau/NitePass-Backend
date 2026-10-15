namespace NitePass.Infrastructure.Persistence
{
    public static class StoredProcedures
    {
        public static class Events
        {
            public const string GetAllEventCategory = "usp_event_categories_list";
        }

        public static class City 
        {
            public const string GetAllCities = "usp_cities_list";
        }
        
    }
}
