using System.Configuration;

namespace Blog
{
    public static class GlobalContext
    {
        public static readonly DatabaseContext DbContext = new DatabaseContext(
            ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
    }
}